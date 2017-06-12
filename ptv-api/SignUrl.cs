using System.Net.Http;
using System.Text;
using PCLCrypto;

namespace ptv_api
{
    public class PtvApi
    {
        public PtvApi(string devid, string devKey)
        {
            DeveloperId = devid;
            DeveloperKey = devKey;
            HttpClient = new HttpClient();
        }

        private string DeveloperId { get; }
        private string DeveloperKey { get; }

        private HttpClient HttpClient { get; }


        private string SignRequestUrl(string url)
        {
            // add developer id
            url = $"{url}{(url.Contains("?") ? "&" : "?")}devid={DeveloperId}";
            var encoding = new UTF8Encoding();
            // encode key
            var keyBytes = encoding.GetBytes(DeveloperKey);
            var urlBytes = encoding.GetBytes(url);
            var algorithm = WinRTCrypto.MacAlgorithmProvider.OpenAlgorithm(MacAlgorithm.HmacSha1);
            var hahser = algorithm.CreateHash(keyBytes);
            hahser.Append(urlBytes);
            var tokenBytes = hahser.GetValueAndReset();
            var sb = new StringBuilder();
            // convert signature to string
            foreach (var b in tokenBytes)
                sb.Append(b.ToString("X2"));
            // add signature to url
            url = $"{url}&signature={sb}";
            return url;
        }
    }
}