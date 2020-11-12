using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Grabber.Networking {

    // Ебал я эту хуйню комментировать
    class FilesListParser : NetworkBehaviour {
        private static readonly Regex regexHrefAndName = new Regex(@"<A .*<\/A>");
        private static readonly Regex regexFileSize = new Regex(@"kB|MB|GB");
        private static readonly Regex regexLastDownload = new Regex(@"((\d*\/\d*\/\d*) (\d*:\d*))");
        private static readonly Regex regexDownloads = new Regex(@"(>([0-9]*.)<)");

        // Путь к файлу (для подстановки)
        private const string FILELIST_PARTICULAR_URL = FAYLOOBMENNIK_URL + "/files/list/";

        public RemoteFile[] ParcePage(int pageNumber, Preferences preferences) {

            string HTMLdata = LoadHTMLpage(BuildFilelistUrl(pageNumber), preferences);

            return HTMLdata != null ? ParseTable(HTMLdata) : null;
        }

        public string BuildFilelistUrl(int pageNumber) {
            return $"{FILELIST_PARTICULAR_URL}{pageNumber}.html";
        }

        // Более общий метод, который возвращает уже готовый массив с инфой о файлах со страницы
        private RemoteFile[] ParseTable(string HTMLData) {
            MatchCollection rawRecords = new Regex(@"<tr .*>(\n* .*)*<\/tr>").Matches(HTMLData);

            List<RemoteFile> records = new List<RemoteFile>();

            foreach (Match m in rawRecords) {
                records.Add(ParseRecord(m.Value));
            }

            return records.ToArray();
        }

        // Список файлов на странице записан в таблицу. Эта херня парсит записи таблицы и достаёт из них инфу о файле.
        // Меняй на свой страх и риск
        private RemoteFile ParseRecord(string rawRecord) {
            RemoteFile remoteFile = new RemoteFile();

            StringReader reader = new StringReader(rawRecord);
            string instanceLine, tmpVal;

            while ((instanceLine = reader.ReadLine()) != null) {

                if (IsHrefAndNameCell(instanceLine)) {
                    tmpVal = regexHrefAndName.Match(instanceLine).Value;
                    remoteFile.href = new Regex("\".*\"").Match(tmpVal).Value.Replace("\"", "");

                    tmpVal = new Regex(">.*<").Match(tmpVal).Value;
                    remoteFile.name = new Regex(@">|<").Replace(tmpVal, "");
                } else if (IsFileSizeCell(instanceLine)) {
                    tmpVal = new Regex(">.*<").Match(instanceLine).Value;
                    remoteFile.size = new Regex(@">|<").Replace(tmpVal, "");
                } else if (IsLastDownloadCell(instanceLine)) {
                    remoteFile.lastDownload = regexLastDownload.Match(instanceLine).Value;
                } else if (IsDownloadsCell(instanceLine)) {
                    remoteFile.downloads = regexDownloads.Match(instanceLine).Groups[2].Value;
                }
            }

            return remoteFile;
        }

        private bool IsHrefAndNameCell(string val) {
            return regexHrefAndName.IsMatch(val);
        }

        private bool IsFileSizeCell(string val) {
            return regexFileSize.IsMatch(val);
        }

        private bool IsLastDownloadCell(string val) {
            return regexLastDownload.IsMatch(val);
        }

        private bool IsDownloadsCell(string val) {
            return regexDownloads.IsMatch(val);
        }
    }
}
