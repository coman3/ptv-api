﻿//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v10.6.6324.28497 (NJsonSchema v8.33.6323.36213) (http://NSwag.org)
// </auto-generated>
//----------------------

namespace PtvApi
{
#pragma warning disable // Disable all warnings


    [System.CodeDom.Compiler.GeneratedCode("NSwag", "10.6.6324.28497")]
    public class SwaggerException<TResult> : SwaggerException
    {
        public TResult Result { get; private set; }

        public SwaggerException(string message, string statusCode, string response,
            System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>> headers,
            TResult result, System.Exception innerException)
            : base(message, statusCode, response, headers, innerException)
        {
            Result = result;
        }
    }


}