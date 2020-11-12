using Grabber.Networking;
using System;
using System.Drawing;
using System.Windows.Forms;
using static Grabber.Networking.FilesDownloader;
// ВНИМАНИЕ! Комментов мало, код сам по себе - кусок кала. Снимаю с себя всю ответственность. 

/*TODO: 
 * - Организовать очередь файлов на загрузку
 * - Загрузка файлов в потоке
 * - Парсинг страниц в потоке
 * - Отображение информации о прогрессе загрузки файла
 * - Отображение информации об общем прогрессе загрузки
 * - Проверка целостности файла после загрузки
 * - Вдохнуть жизнь в FormPreferences
 * - Сохранение настроек в ini файл
 * - Загрузка настроек из файла при запуске
 * - Вытолкать методы из FormMain, которые не относятся к GUI, в отдельный класс
 * - Вытолкать содержимое обработчиков в отдельные методы
 * - Организовать адекватное отображение кол-ва файлов в ListView (шоб по красоте)
 * - И ещё дохуя-дохуя чего
 */

/* 
 * FIXME: 
 * - Вероятно есть баг с переключением радиобатона на "Do not download extentions" и пустым tbExtentions. 
 * По идее вообще ничего не должно загружаться.
 * - Сейчас во время парсинга страниц с сайта и во время загрузки интерфейс программы зависает. Нужно пилить потоки
 * - Вместо метода Clear() использовать что-то пошустрее, ибо при большом кол-ве записей в ListView Clear() работает очень долго
 */
namespace Grabber {

    public partial class MainForm : Form {
        private bool downloadExtentions = true;
        public Preferences preferences = FormPreferences.PREF_DEFAULT.Copy();

        public MainForm() {
            InitializeComponent();
        }

        // Используется для указания цвета записи в логе
        private enum LogType {
            Error = -1,
            None = 0,
            Success = 1,
            Alert = 2,
            Attention = 3
        }

        // Можно снести
        private void LvFilesList_ControlAdded(object sender, ControlEventArgs e) { 
            ShowStatus("Item added"); 
        }

        /**
         *  Добавляет инфу о файле с распарсенной (хз есть ли такое слово) страницы в список
         */
        private void AddFileToList(RemoteFile file) {
            ListViewItem fileItem = new ListViewItem();
            fileItem.Checked = false;
            _ = fileItem.SubItems.Add(file.name);
            _ = fileItem.SubItems.Add(file.size);
            _ = fileItem.SubItems.Add(file.downloads);
            _ = fileItem.SubItems.Add(file.href);
            fileItem.Tag = file;
            _ = lvFilesList.Items.Add(fileItem);

            ShowStatus($"Size: {lvFilesList.Items.Count}");
        }

        private void ShowStatus(string line) {
            lbStatus.Text = line;
        }

        // Записывает цветное сообщение в logBox
        private void Log(string line, LogType logType = LogType.None) {

            logBox.SelectionStart = logBox.TextLength;
            logBox.SelectionLength = 0;

            logBox.SelectionColor = ChooseLogColor(logType);
            logBox.AppendText(line + '\n');
            logBox.SelectionColor = logBox.ForeColor;
        }

        // Выбирает цвет вывода текста в зависимости от передаваемого enum
        private Color ChooseLogColor(LogType logType) {
            switch (logType) {
                case LogType.None:
                return Color.Black;
                case LogType.Error:
                return Color.Red;
                case LogType.Success:
                return Color.DarkGreen;
                case LogType.Alert:
                return Color.Brown;
                case LogType.Attention:
                return Color.DarkOrange;

                default:
                return Color.Gray;
            }
        }

        // ВЫНЕСТИ ИЗ ОБРАБОТЧИКА
        // Собирает инфу о том с какой по какую страницы парсить, и производит собственно сам парсинг.
        // Добавляет в список только те файлы, которых там ещё нет
        private void BtLoadPages_Click(object sender, EventArgs e) {
            RemoteFile[] parsedList;
            int pageFrom = (int)nudPageFrom.Value;
            int pageTo = (int)nudPageTo.Value + 1;

            var pagesParser = new FilesListParser();
            for (int i = pageFrom; i < pageTo; i++) {
                parsedList = pagesParser.ParcePage(i, preferences);
                if (parsedList != null) {
                    AddUnique(parsedList);
                } else {
                    Log($"Page loading error. Page: {pagesParser.BuildFilelistUrl(i)}", LogType.Error);
                }
            }
        }

        // ВЫНЕСТИ ИЗ ОБРАБОТЧИКА
        // Получает список отмеченных галочкой файлов, сверяет имя каждого файла с маской из tbExtentions, 
        // и на основе радиобатона загружает/не загружает файл
        private void BtDownload_Click(object sender, EventArgs e) {
            string[] extentions = tbExtentions.Text.Split(',');
            var downloader = new FilesDownloader();
            RemoteFile instant;
            DownloadResult result;

            foreach (ListViewItem item in lvFilesList.CheckedItems) {
                instant = (RemoteFile)item.Tag;
                if (downloadExtentions ?
                    containsExtentions(instant, extentions) :
                    !containsExtentions(instant, extentions)) {
                result = downloader.DownloadFile(preferences, instant);
                    LogDownloadResult(result);
                }
            }
        }

        ////// Всё что ниже - тупо лирика //////

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e) {
            foreach (ListViewItem item in lvFilesList.Items) {
                item.Remove();
            }
            ShowStatus(lvFilesList.Items.Count.ToString());
        }

        private void RemoveCheckedToolStripMenuItem_Click(object sender, EventArgs e) {
            foreach (ListViewItem item in lvFilesList.CheckedItems) {
                item.Remove();
            }
            ShowStatus(lvFilesList.Items.Count.ToString());
        }

        private void RemoveSelectedToolStripMenuItem_Click(object sender, EventArgs e) {
            foreach (ListViewItem item in lvFilesList.SelectedItems) {
                item.Remove();
            }
            ShowStatus(lvFilesList.Items.Count.ToString());
        }

        private void LogDownloadResult(DownloadResult result) {
            switch (result.Code) {
                case DownloadResult.ResultCode.Success:
                Log($"SUCCESS: {result.FileName}", LogType.Success);
                break;
                case DownloadResult.ResultCode.WebException:
                Log($"Interrupted: {result.FileName} | {result.FileUrl}", LogType.Error);
                break;
                case DownloadResult.ResultCode.RequestFailed:
                Log($"Request failed: {result.FileName} | {result.FileUrl}", LogType.Error);
                break;
                case DownloadResult.ResultCode.NotComplete:
                Log($"Not fully loaded: {result.FileName} | {result.FileUrl}", LogType.Error);
                break;

                default:
                Log("WTF?", LogType.None);
                break;
            }
        }

        private bool containsExtentions(RemoteFile file, string[] extentions) {
            foreach (string ext in extentions) {
                if (file.name.EndsWith(ext))
                    return true;
            }
            return false;
        }

        private void AddUnique(RemoteFile[] range) {
            foreach (RemoteFile instance in range) {
                if (!IsInCollection(instance))
                    AddFileToList(instance);
            }
        }

        private bool IsInCollection(RemoteFile file) {
            foreach (ListViewItem instant in lvFilesList.Items) {
                if (file.Equals(instant.Tag))
                    return true;
            }

            return false;
        }

        private void SetCheckGlobal(int val) {
            foreach (ListViewItem item in lvFilesList.Items) {
                switch (val) {
                    case 0:
                    item.Checked = false;
                    break;
                    case 1:
                    item.Checked = true;
                    break;
                    case 2:
                    item.Checked = !item.Checked;
                    break;
                }
            }
        }

        private void SetSelectionGlobal(int val) {
            foreach (ListViewItem item in lvFilesList.Items) {
                switch (val) {
                    case 0:
                    item.Selected = false;
                    break;
                    case 1:
                    item.Selected = true;
                    break;
                    case 2:
                    item.Selected = !item.Selected;
                    break;
                }
            }
        }

        private void rbDownload_CheckedChanged(object sender, EventArgs e) {
            if ((sender as RadioButton).Checked)
                downloadExtentions = true;
        }

        private void rbDontDownload_CheckedChanged(object sender, EventArgs e) {
            if ((sender as RadioButton).Checked)
                downloadExtentions = false;
        }

        // Дублирование
        private void CheckAllToolStripMenuItem_Click(object sender, EventArgs e) {
            SetCheckGlobal(1);
        }

        private void UncheckAllToolStripMenuItem_Click(object sender, EventArgs e) {
            SetCheckGlobal(0);
        }

        private void InvertCheckingToolStripMenuItem_Click(object sender, EventArgs e) {
            SetCheckGlobal(2);
        }

        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e) {
            SetSelectionGlobal(1);
        }

        private void InvertSelectionToolStripMenuItem_Click(object sender, EventArgs e) {
            SetSelectionGlobal(2);
        }

        private void UnselectAllToolStripMenuItem_Click(object sender, EventArgs e) {
            SetSelectionGlobal(0);
        }

        private void TbExtentions_TextChanged(object sender, EventArgs e) {
            pExtentionsChoose.Enabled = !((sender as TextBox).Text.Length == 0);
        }
    }
}