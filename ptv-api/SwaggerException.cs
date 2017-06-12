using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace PtvApi
{
    [GeneratedCode("NSwag", "10.6.6324.28497")]
    public class SwaggerException : Exception
    {
        public SwaggerException(string message, string statusCode, string response,
            Dictionary<string, IEnumerable<string>> headers,
            Exception innerException)
            : base(message, innerException)
        {
            StatusCode = statusCode;
            Response = response;
            Headers = headers;
        }

        public string StatusCode { get; }

        public string Response { get; }

        public Dictionary<string, IEnumerable<string>> Headers { get; }

        public override string ToString()
        {
            return string.Format("HTTP Response: \n\n{0}\n\n{1}", Response, base.ToString());
        }
    }
}