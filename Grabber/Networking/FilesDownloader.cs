using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace Grabber.Networking {

    class FilesDownloader : NetworkBehaviour {
        // Используется чтобы передать результат загрузки отсюда в вызывающий класс.
        // Вообще, в задумке сделать Networking вообще независимой от чего либо и абсолютно самостоятельной.
        // Типа: Подключил и пользуйся на здоровье
        public struct DownloadResult {
            public enum ResultCode {
                Success,
                RequestFailed,
                NotComplete,
                WebException,
                FileNotWrited,
                Default
            }

            public string FileName { get; internal set; }
            public string FileUrl { get; internal set; }
            public ResultCode Code { get; internal set; }

            internal DownloadResult(string fileName, string fileUrl) {
                FileName = fileName;
                Code = ResultCode.Default;
                FileUrl = fileUrl;
            }
        }

        // Собственно сама качалка
        public DownloadResult DownloadFile(Preferences preferences, RemoteFile record) {
            string fileFullPath = $"{preferences.targetFolder}{record.name}";
            string fileFullUrl = $"{FAYLOOBMENNIK_URL}{record.href }";

            var result = new DownloadResult {
                FileName = fileFullPath,
                FileUrl = fileFullUrl
            };

            string remoteFileUrl = ParseFileDirectLink(fileFullUrl, preferences);

            if (remoteFileUrl == null) {
                result.Code = DownloadResult.ResultCode.RequestFailed;
                return result;
            }

            try {
                using (WebClient wc = new WebClient()) {
                    wc.DownloadFile(new Uri(remoteFileUrl), fileFullPath);

                }
                result.Code = DownloadResult.ResultCode.Success;
            } catch (WebException) {
                result.Code = DownloadResult.ResultCode.WebException;
            }
            return result;
        }

        // Должен будет проверять наличие/отсутствие/целостность файла после загрузки, возвращать ResultCode
        // И на основе этого дальше уже смотреть что да как
        private DownloadResult.ResultCode CheckFileIntegrity(string localFilePath, long remoteSize) {
            if (!File.Exists(localFilePath)) {
                return DownloadResult.ResultCode.FileNotWrited;
            } else if (new FileInfo(localFilePath).Length != remoteSize) {
                return DownloadResult.ResultCode.NotComplete;
            } else {
                return DownloadResult.ResultCode.Success;
            }
        }

        // Не использовать! Иногда работает нормально, а иногда зависает навечно.
        // Пока не понял как этим пользоваться
        private long GetRemoteFileSize(string url) {
            WebRequest req = WebRequest.CreateHttp(url);
            req.Timeout = 500;
            return req.GetResponse().ContentLength;
        }

        // Находит на странице с файлом кнопку "Скачать" и достаёт из неё прямую ссылку на файл
        private string ParseFileDirectLink(string url, Preferences preferences) {
            string filePage = LoadHTMLpage(url, preferences);

            if (filePage == null)
                return null;

            StringReader filePageReader = new StringReader(filePage);

            string instantLine, directLink = null;
            while ((instantLine = filePageReader.ReadLine()) != null) {
                if (instantLine.Contains(">Скачать<")) {
                    directLink = new Regex($"\"(.*?)\"").Matches(instantLine)[1].Value.Replace("\"", "");
                    break;
                }
            }
            filePageReader.Close();

            return directLink;
        }
    }
}
