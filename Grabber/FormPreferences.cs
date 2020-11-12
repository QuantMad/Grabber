using System;
using System.Windows.Forms;

namespace Grabber {
    public struct Preferences {
        public int
            requestDelay, // Задержка между запросами страниц со списком файлов
            requestTimeout, // Время ожидания страницы от сайта
            downloadDelay, // Задержка 
            requestAttempts, // Попытки получить страницу со списком файлов в случае неудачи
            downloadAttempts; // Попытки загрузить файл в случае неудачи
        public bool 
            saveListOnExit, // Сохранять ли список при выходе
            logToFile; // Записывать ли лог в файл?
        public string targetFolder; // Целевая папка загрузки

        public Preferences Copy() {
            Preferences copy = new Preferences();
            copy.requestDelay = requestDelay;
            copy.requestTimeout = requestTimeout;
            copy.downloadDelay = downloadDelay;
            copy.requestAttempts = requestAttempts;
            copy.downloadAttempts = downloadAttempts;
            copy.saveListOnExit = saveListOnExit;
            copy.targetFolder = targetFolder;
            copy.logToFile = logToFile;

            return copy;
        }
    }

    public partial class FormPreferences : Form {

        // Пресет настроек по умолчанию
        public static readonly Preferences PREF_DEFAULT = new Preferences {
            requestDelay = 1000,
            requestTimeout = 5000,
            downloadDelay = 200,
            requestAttempts = 1,
            downloadAttempts = 1,
            saveListOnExit = true,
            logToFile = true,
            targetFolder = @"D:\test\"
        };

        public FormPreferences() {
            InitializeComponent();
        }

        private void FomrPreferencer_Load(object sender, EventArgs e) {

        }
    }
}
