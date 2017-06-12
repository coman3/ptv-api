using System;
using System.CodeDom.Compiler;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ptv_api.Models;
using ptv_api.Models.Responses;

namespace ptv_api.Clients
{
    [GeneratedCode("NSwag", "10.6.6324.28497")]
    public partial class PatternsClient : PtvClient
    {
        /// <summary>View the stopping pattern for a specific trip/service run</summary>
        /// <param name="runId">
        ///     Identifier of a trip/service run; values returned by Runs API - /v3/route/{route_id} and Departures
        ///     API
        /// </param>
        /// <param name="routeType">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="stopId">Filter by stop_id; values returned by Stops API</param>
        /// <param name="dateUtc">Filter by the date and time of the request (ISO 8601 UTC format)</param>
        /// <returns>The stopping pattern of the specified trip/service run and route type.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public Task<StoppingPattern> GetPatternByRunAsync(int runId, RouteTypes routeType, int? stopId, DateTime? dateUtc)
        {
            return GetPatternByRunAsync(runId, routeType, stopId, dateUtc, CancellationToken.None);
        }

        /// <summary>View the stopping pattern for a specific trip/service run</summary>
        /// <param name="runId">
        ///     Identifier of a trip/service run; values returned by Runs API - /v3/route/{route_id} and Departures
        ///     API
        /// </param>
        /// <param name="routeType">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="stopId">Filter by stop_id; values returned by Stops API</param>
        /// <param name="dateUtc">Filter by the date and time of the request (ISO 8601 UTC format)</param>
        /// <returns>The stopping pattern of the specified trip/service run and route type.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public StoppingPattern GetPatternByRun(int runId, RouteTypes routeType, int? stopId, DateTime? dateUtc)
        {
            return Task.Run(async () => await GetPatternByRunAsync(runId, routeType, stopId, dateUtc, CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <summary>View the stopping pattern for a specific trip/service run</summary>
        /// <param name="runId">
        ///     Identifier of a trip/service run; values returned by Runs API - /v3/route/{route_id} and Departures
        ///     API
        /// </param>
        /// <param name="routeType">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="stopId">Filter by stop_id; values returned by Stops API</param>
        /// <param name="dateUtc">Filter by the date and time of the request (ISO 8601 UTC format)</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <returns>The stopping pattern of the specified trip/service run and route type.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async Task<StoppingPattern> GetPatternByRunAsync(int runId, RouteTypes routeType, int? stopId, DateTime? dateUtc, CancellationToken cancellationToken)
        {
            var urlBuilder = new StringBuilder();
            urlBuilder.Append("/v3/pattern/run/{run_id}/route_type/{route_type}?");
            urlBuilder.Replace("{run_id}", Uri.EscapeDataString(runId.ToString()));
            urlBuilder.Replace("{route_type}", Uri.EscapeDataString(routeType.ToString()));
            if (stopId != null)
                urlBuilder.Append("stop_id=").Append(Uri.EscapeDataString(stopId.Value.ToString())).Append("&");
            if (dateUtc != null)
                urlBuilder.Append("date_utc=").Append(Uri.EscapeDataString(dateUtc.Value.ToString("s", CultureInfo.InvariantCulture))).Append("&");

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
                            response.Headers.ToDictionary(h => h.Key, h => h.Value);
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
                                result = JsonConvert.DeserializeObject<StoppingPattern>(responseData);
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

                        return default(StoppingPattern);
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

        public PatternsClient(string devid, string devKey) : base(devid, devKey)
        {
        }
    }
}