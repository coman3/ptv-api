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
    public partial class RunsClient
    {
        public string BaseUrl { get; set; } = "http://timetableapi.ptv.vic.gov.au";

        partial void PrepareRequest(HttpClient client, HttpRequestMessage request,
            string url);

        partial void PrepareRequest(HttpClient client, HttpRequestMessage request,
            StringBuilder urlBuilder);

        partial void ProcessResponse(HttpClient client, HttpResponseMessage response);

        /// <summary>View all trip/service runs for a specific route ID</summary>
        /// <param name="routeId">Identifier of route; values returned by Routes API - v3/routes.</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>All trip/service run details for the specified route ID.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public Task<RunsResponse> ForRouteAsync(int routeId, string token, string devid,
            string signature)
        {
            return ForRouteAsync(routeId, token, devid, signature, CancellationToken.None);
        }

        /// <summary>View all trip/service runs for a specific route ID</summary>
        /// <param name="routeId">Identifier of route; values returned by Routes API - v3/routes.</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>All trip/service run details for the specified route ID.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public RunsResponse ForRoute(int routeId, string token, string devid, string signature)
        {
            return Task
                .Run(async () => await ForRouteAsync(routeId, token, devid, signature,
                    CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <summary>View all trip/service runs for a specific route ID</summary>
        /// <param name="routeId">Identifier of route; values returned by Routes API - v3/routes.</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <returns>All trip/service run details for the specified route ID.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async Task<RunsResponse> ForRouteAsync(int routeId, string token, string devid,
            string signature, CancellationToken cancellationToken)
        {
            var urlBuilder = new StringBuilder();
            urlBuilder.Append(BaseUrl).Append("/v3/runs/route/{route_id}?");
            urlBuilder.Replace("{route_id}", Uri.EscapeDataString(routeId.ToString()));
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
                        var headers = response.Headers.ToDictionary(h => h.Key, h => h.Value);
                        foreach (var item in response.Content.Headers)
                            headers[item.Key] = item.Value;

                        ProcessResponse(client, response);

                        var status = ((int) response.StatusCode).ToString();
                        if (status == "200")
                        {
                            var responseData = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result = default(RunsResponse);
                            try
                            {
                                result = JsonConvert.DeserializeObject<RunsResponse>(responseData);
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

                        return default(RunsResponse);
                    }
                    finally
                    {
                        response?.Dispose();
                    }
                }
            }
            finally
            {
                client?.Dispose();
            }
        }

        /// <summary>View all trip/service runs for a specific run ID</summary>
        /// <param name="runId">
        ///     Identifier of a trip/service run; values returned by Runs API - /v3/route/{route_id} and Departures
        ///     API
        /// </param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>All trip/service run details for the specified run ID.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public Task<RunsResponse> ForRunAsync(int runId, string token, string devid,
            string signature)
        {
            return ForRunAsync(runId, token, devid, signature, CancellationToken.None);
        }

        /// <summary>View all trip/service runs for a specific run ID</summary>
        /// <param name="runId">
        ///     Identifier of a trip/service run; values returned by Runs API - /v3/route/{route_id} and Departures
        ///     API
        /// </param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>All trip/service run details for the specified run ID.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public RunsResponse ForRun(int runId, string token, string devid, string signature)
        {
            return Task
                .Run(async () => await ForRunAsync(runId, token, devid, signature,
                    CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <summary>View all trip/service runs for a specific run ID</summary>
        /// <param name="runId">
        ///     Identifier of a trip/service run; values returned by Runs API - /v3/route/{route_id} and Departures
        ///     API
        /// </param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <returns>All trip/service run details for the specified run ID.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async Task<RunsResponse> ForRunAsync(int runId, string token, string devid,
            string signature, CancellationToken cancellationToken)
        {
            var urlBuilder = new StringBuilder();
            urlBuilder.Append(BaseUrl).Append("/v3/runs/{run_id}?");
            urlBuilder.Replace("{run_id}", Uri.EscapeDataString(runId.ToString()));
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
                        var headers = response.Headers.ToDictionary(h => h.Key, h => h.Value);
                        foreach (var item in response.Content.Headers)
                            headers[item.Key] = item.Value;

                        ProcessResponse(client, response);

                        var status = ((int) response.StatusCode).ToString();
                        if (status == "200")
                        {
                            var responseData = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result = default(RunsResponse);
                            try
                            {
                                result = JsonConvert.DeserializeObject<RunsResponse>(responseData);
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

                        return default(RunsResponse);
                    }
                    finally
                    {
                        response?.Dispose();
                    }
                }
            }
            finally
            {
                client?.Dispose();
            }
        }

        /// <summary>View the trip/service run for a specific run ID and route type</summary>
        /// <param name="runId">
        ///     Identifier of a trip/service run; values returned by Runs API - /v3/route/{route_id} and Departures
        ///     API
        /// </param>
        /// <param name="routeType">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>The trip/service run details for the run ID and route type specified.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public Task<RunResponse> ForRunAndRouteTypeAsync(int runId, RouteTypes routeType,
            string token, string devid, string signature)
        {
            return ForRunAndRouteTypeAsync(runId, routeType, token, devid, signature,
                CancellationToken.None);
        }

        /// <summary>View the trip/service run for a specific run ID and route type</summary>
        /// <param name="runId">
        ///     Identifier of a trip/service run; values returned by Runs API - /v3/route/{route_id} and Departures
        ///     API
        /// </param>
        /// <param name="routeType">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>The trip/service run details for the run ID and route type specified.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public RunResponse ForRunAndRouteType(int runId, RouteTypes routeType, string token, string devid,
            string signature)
        {
            return Task.Run(async () => await ForRunAndRouteTypeAsync(runId, routeType, token,
                devid, signature, CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <summary>View the trip/service run for a specific run ID and route type</summary>
        /// <param name="runId">
        ///     Identifier of a trip/service run; values returned by Runs API - /v3/route/{route_id} and Departures
        ///     API
        /// </param>
        /// <param name="routeType">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <returns>The trip/service run details for the run ID and route type specified.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async Task<RunResponse> ForRunAndRouteTypeAsync(int runId,
            RouteTypes routeType, string token, string devid, string signature,
            CancellationToken cancellationToken)
        {
            var urlBuilder = new StringBuilder();
            urlBuilder.Append(BaseUrl).Append("/v3/runs/{run_id}/route_type/{route_type}?");
            urlBuilder.Replace("{run_id}", Uri.EscapeDataString(runId.ToString()));
            urlBuilder.Replace("{route_type}", Uri.EscapeDataString(routeType.ToString()));
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
                        var headers = response.Headers.ToDictionary(h => h.Key, h => h.Value);
                        foreach (var item in response.Content.Headers)
                            headers[item.Key] = item.Value;

                        ProcessResponse(client, response);

                        var status = ((int) response.StatusCode).ToString();
                        if (status == "200")
                        {
                            var responseData = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result = default(RunResponse);
                            try
                            {
                                result = JsonConvert.DeserializeObject<RunResponse>(responseData);
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

                        return default(RunResponse);
                    }
                    finally
                    {
                        response?.Dispose();
                    }
                }
            }
            finally
            {
                client?.Dispose();
            }
        }
    }
}