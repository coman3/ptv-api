namespace PtvApi
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "10.6.6324.28497")]
    public partial class PatternsClient
    {
        public string BaseUrl { get; set; } = "http://timetableapi.ptv.vic.gov.au";

        partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request,
            string url);

        partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request,
            System.Text.StringBuilder urlBuilder);

        partial void ProcessResponse(System.Net.Http.HttpClient client, System.Net.Http.HttpResponseMessage response);

        /// <summary>View the stopping pattern for a specific trip/service run</summary>
        /// <param name="runId">Identifier of a trip/service run; values returned by Runs API - /v3/route/{route_id} and Departures API</param>
        /// <param name="routeType">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="stopId">Filter by stop_id; values returned by Stops API</param>
        /// <param name="dateUtc">Filter by the date and time of the request (ISO 8601 UTC format)</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>The stopping pattern of the specified trip/service run and route type.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<StoppingPattern> GetPatternByRunAsync(int runId, RouteTypes routeType,
            int? stopId, System.DateTime? dateUtc, string token, string devid, string signature)
        {
            return GetPatternByRunAsync(runId, routeType, stopId, dateUtc, token, devid, signature,
                System.Threading.CancellationToken.None);
        }

        /// <summary>View the stopping pattern for a specific trip/service run</summary>
        /// <param name="runId">Identifier of a trip/service run; values returned by Runs API - /v3/route/{route_id} and Departures API</param>
        /// <param name="routeType">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="stopId">Filter by stop_id; values returned by Stops API</param>
        /// <param name="dateUtc">Filter by the date and time of the request (ISO 8601 UTC format)</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>The stopping pattern of the specified trip/service run and route type.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public StoppingPattern GetPatternByRun(int runId, RouteTypes routeType, int? stopId,
            System.DateTime? dateUtc, string token, string devid, string signature)
        {
            return System.Threading.Tasks.Task.Run(async () => await GetPatternByRunAsync(runId, routeType, stopId,
                dateUtc, token, devid, signature, System.Threading.CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <summary>View the stopping pattern for a specific trip/service run</summary>
        /// <param name="runId">Identifier of a trip/service run; values returned by Runs API - /v3/route/{route_id} and Departures API</param>
        /// <param name="routeType">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="stopId">Filter by stop_id; values returned by Stops API</param>
        /// <param name="dateUtc">Filter by the date and time of the request (ISO 8601 UTC format)</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The stopping pattern of the specified trip/service run and route type.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<StoppingPattern> GetPatternByRunAsync(int runId,
            RouteTypes routeType, int? stopId, System.DateTime? dateUtc, string token, string devid,
            string signature, System.Threading.CancellationToken cancellationToken)
        {
            if (runId == null)
                throw new System.ArgumentNullException("runId");

            if (routeType == null)
                throw new System.ArgumentNullException("routeType");

            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl).Append("/v3/pattern/run/{run_id}/route_type/{route_type}?");
            urlBuilder.Replace("{run_id}", System.Uri.EscapeDataString(runId.ToString()));
            urlBuilder.Replace("{route_type}", System.Uri.EscapeDataString(routeType.ToString()));
            if (stopId != null)
                urlBuilder.Append("stop_id=").Append(System.Uri.EscapeDataString(stopId.Value.ToString()))
                    .Append("&");
            if (dateUtc != null)
                urlBuilder.Append("date_utc=")
                    .Append(System.Uri.EscapeDataString(
                        dateUtc.Value.ToString("s", System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            if (token != null)
                urlBuilder.Append("token=").Append(System.Uri.EscapeDataString(token.ToString())).Append("&");
            if (devid != null)
                urlBuilder.Append("devid=").Append(System.Uri.EscapeDataString(devid.ToString())).Append("&");
            if (signature != null)
                urlBuilder.Append("signature=").Append(System.Uri.EscapeDataString(signature.ToString())).Append("&");
            urlBuilder.Length--;

            var client = new System.Net.Http.HttpClient();
            try
            {
                using (var request = new System.Net.Http.HttpRequestMessage())
                {
                    request.Method = new System.Net.Http.HttpMethod("GET");
                    request.Headers.Accept.Add(
                        new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    PrepareRequest(client, request, urlBuilder);
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client, request, url);

                    var response = await client.SendAsync(request,
                            System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    try
                    {
                        var headers =
                            System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        foreach (var item in response.Content.Headers)
                            headers[item.Key] = item.Value;

                        ProcessResponse(client, response);

                        var status = ((int) response.StatusCode).ToString();
                        if (status == "200")
                        {
                            var responseData = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result = default(StoppingPattern);
                            try
                            {
                                result = Newtonsoft.Json.JsonConvert.DeserializeObject<StoppingPattern>(responseData);
                                return result;
                            }
                            catch (System.Exception exception)
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
                                result = Newtonsoft.Json.JsonConvert.DeserializeObject<ErrorResponse>(responseData);
                            }
                            catch (System.Exception exception)
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
                                result = Newtonsoft.Json.JsonConvert.DeserializeObject<ErrorResponse>(responseData);
                            }
                            catch (System.Exception exception)
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

                        return default(StoppingPattern);
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