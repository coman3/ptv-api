using System;
using System.Net.Http;
using System.Text;
using PCLCrypto;

namespace ptv_api
{
    public abstract class PtvClient
    {
        public string BaseUrl { get; set; } = "http://timetableapi.ptv.vic.gov.au";

        protected PtvClient(string devid, string devKey)
        {
            DeveloperId = devid;
            DeveloperKey = devKey;
            HttpClient = new HttpClient();
        }

        private string DeveloperId { get; }
        private string DeveloperKey { get; }

        private HttpClient HttpClient { get; }

        protected void PrepareRequest(HttpClient client, HttpRequestMessage request, StringBuilder urlBuilder)
        {

            if (DeveloperId == null || DeveloperKey == null)
                throw new ArgumentNullException(nameof(DeveloperId) + "|" + nameof(DeveloperKey));

            var currentUrl = urlBuilder.ToString();
            urlBuilder.Append("devid=").Append(Uri.EscapeDataString(DeveloperId)).Append("&");
            urlBuilder.Append("signature=").Append(Uri.EscapeDataString(SignRequestUrl(currentUrl)));
        }

        protected void PrepareRequest(HttpClient client, HttpRequestMessage request, string url)
        {
            
        }

        protected void ProcessResponse(HttpClient client, HttpResponseMessage response)
        {
            
        }

        private string SignRequestUrl(string url)
        {
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
            return sb.ToString();
        }
    }
}