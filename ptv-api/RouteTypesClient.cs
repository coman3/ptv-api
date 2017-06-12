using System;
using System.CodeDom.Compiler;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PtvApi
{
    [GeneratedCode("NSwag", "10.6.6324.28497")]
    public partial class RouteTypesClient
    {
        public string BaseUrl { get; set; } = "http://timetableapi.ptv.vic.gov.au";

        partial void PrepareRequest(HttpClient client, HttpRequestMessage request,
            string url);

        partial void PrepareRequest(HttpClient client, HttpRequestMessage request,
            StringBuilder urlBuilder);

        partial void ProcessResponse(HttpClient client, HttpResponseMessage response);

        /// <summary>View all route types and their names</summary>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>All route types (i.e. identifiers of transport modes) and their names.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public Task<RouteTypesResponse> GetRouteTypesAsync(string token, string devid,
            string signature)
        {
            return GetRouteTypesAsync(token, devid, signature, CancellationToken.None);
        }

        /// <summary>View all route types and their names</summary>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>All route types (i.e. identifiers of transport modes) and their names.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public RouteTypesResponse GetRouteTypes(string token, string devid, string signature)
        {
            return Task
                .Run(async () => await GetRouteTypesAsync(token, devid, signature,
                    CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <summary>View all route types and their names</summary>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <returns>All route types (i.e. identifiers of transport modes) and their names.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async Task<RouteTypesResponse> GetRouteTypesAsync(string token, string devid,
            string signature, CancellationToken cancellationToken)
        {
            var urlBuilder = new StringBuilder();
            urlBuilder.Append(BaseUrl).Append("/v3/route_types?");
            if (token != null)
                urlBuilder.Append("token=").Append(Uri.EscapeDataString(token)).Append("&");
            if (devid != null)
                urlBuilder.Append("devid=").Append(Uri.EscapeDataString(devid)).Append("&");
            if (signature != null)
                urlBuilder.Append("signature=").Append(Uri.EscapeDataString(signature)).Append("&");
            urlBuilder.Length--;

            var client = new HttpClient();
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    request.Method = new HttpMethod("GET");
                    request.Headers.Accept.Add(
                        new MediaTypeWithQualityHeaderValue("application/json"));

                    PrepareRequest(client, request, urlBuilder);
                    var url = urlBuilder.ToString();
                    request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                    PrepareRequest(client, request, url);

                    var response = await client.SendAsync(request,
                            HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    try
                    {
                        var headers =
                            Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        foreach (var item in response.Content.Headers)
                            headers[item.Key] = item.Value;

                        ProcessResponse(client, response);

                        var status = ((int) response.StatusCode).ToString();
                        if (status == "200")
                        {
                            var responseData = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result = default(RouteTypesResponse);
                            try
                            {
                                result =
                                    JsonConvert.DeserializeObject<RouteTypesResponse>(responseData);
                                return result;
                            }
                            catch (Exception exception)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", status,
                                    responseData, headers, exception);
                            }
                        }
                        else if (status == "400")
                        {
                            var responseData = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result = default(ErrorResponse);
                            try
                            {
                                result = JsonConvert.DeserializeObject<ErrorResponse>(responseData);
                            }
                            catch (Exception exception)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", status,
                                    responseData, headers, exception);
                            }
                            throw new SwaggerException<ErrorResponse>("Invalid Request", status, responseData,
                                headers, result, null);
                        }
                        else if (status == "403")
                        {
                            var responseData = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result = default(ErrorResponse);
                            try
                            {
                                result = JsonConvert.DeserializeObject<ErrorResponse>(responseData);
                            }
                            catch (Exception exception)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", status,
                                    responseData, headers, exception);
                            }
                            throw new SwaggerException<ErrorResponse>("Access Denied", status, responseData, headers,
                                result, null);
                        }
                        else if (status != "200" && status != "204")
                        {
                            var responseData = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new SwaggerException(
                                "The HTTP status code of the response was not expected (" + (int) response.StatusCode +
                                ").", status, responseData, headers, null);
                        }

                        return default(RouteTypesResponse);
                    }
                    finally
                    {
                        if (response != null)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (client != null)
                    client.Dispose();
            }
        }
    }
}