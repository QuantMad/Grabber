using System;
using System.Net.Http;
using System.Text;

namespace Grabber.Networking {
    public struct RemoteFile {
        public string name;
        public string size;
        public string downloads;
        public string lastDownload;
        public string href;

        public RemoteFile(string name, string size, string downloads, string href) {
            this.name = name;
            this.size = size;
            this.downloads = downloads;
            this.href = href;
            lastDownload = ""; 
        }
    }

    internal abstract class NetworkBehaviour {
        internal const string FAYLOOBMENNIK_URL = "http://fayloobmennik.cloud";

        // ОБРАБОТАТЬ HttpRequestException
        internal string LoadHTMLpage(string URL, Preferences preferences) {

            HttpClient client = new HttpClient {
                BaseAddress = new Uri(URL),
                Timeout = TimeSpan.FromMilliseconds(preferences.requestTimeout)
            };

            byte[] response;

            try {
                response = client.GetByteArrayAsync(client.BaseAddress).Result;
            } catch {
                return null;
            }

            return Encoding.Default.GetString(response);

        }
    }
}