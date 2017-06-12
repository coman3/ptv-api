using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ptv_api
{
    [GeneratedCode("NSwag", "10.6.6324.28497")]
    public partial class DisruptionsClient : PtvClient
    {
        /// <summary>View all disruptions for all route types</summary>
        /// <param name="routeTypes">Filter by route_type; values returned via RouteTypes API</param>
        /// <param name="disruptionStatus">Filter by status of disruption</param>
        /// <returns>All disruption information for all route types.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public Task<DisruptionsResponse> GetAllDisruptionsAsync(IEnumerable<RouteTypes> routeTypes, DisruptionStatus? disruptionStatus)
        {
            return GetAllDisruptionsAsync(routeTypes, disruptionStatus, CancellationToken.None);
        }

        /// <summary>View all disruptions for all route types</summary>
        /// <param name="routeTypes">Filter by route_type; values returned via RouteTypes API</param>
        /// <param name="disruptionStatus">Filter by status of disruption</param>
        /// <returns>All disruption information for all route types.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public DisruptionsResponse GetAllDisruptions(IEnumerable<RouteTypes> routeTypes, DisruptionStatus? disruptionStatus)
        {
            return Task.Run(async () => await GetAllDisruptionsAsync(routeTypes, disruptionStatus,  CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <summary>View all disruptions for all route types</summary>
        /// <param name="routeTypes">Filter by route_type; values returned via RouteTypes API</param>
        /// <param name="disruptionStatus">Filter by status of disruption</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <returns>All disruption information for all route types.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async Task<DisruptionsResponse> GetAllDisruptionsAsync(
            IEnumerable<RouteTypes> routeTypes, DisruptionStatus? disruptionStatus, CancellationToken cancellationToken)
        {
            var urlBuilder = new StringBuilder();
            urlBuilder.Append("/v3/disruptions?");
            if (routeTypes != null)
                urlBuilder.Append("route_types=").Append(Uri.EscapeDataString(string.Join(",", routeTypes))).Append("&");
            if (disruptionStatus != null)
                urlBuilder.Append("disruption_status=")
                    .Append(Uri.EscapeDataString(disruptionStatus.Value.ToString())).Append("&");

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
                            var result = default(DisruptionsResponse);
                            try
                            {
                                result =
                                    JsonConvert.DeserializeObject<DisruptionsResponse>(responseData);
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

                        return default(DisruptionsResponse);
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

        /// <summary>View all disruptions for a particular route</summary>
        /// <param name="routeId">Identifier of route; values returned by Routes API - v3/routes</param>
        /// <param name="disruptionStatus">Filter by status of disruption</param>
        /// <returns>All disruption information (if any exists) for the specified route.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public Task<DisruptionsResponse> GetDisruptionsByRouteAsync(int routeId, DisruptionStatus2? disruptionStatus)
        {
            return GetDisruptionsByRouteAsync(routeId, disruptionStatus, 
                CancellationToken.None);
        }

        /// <summary>View all disruptions for a particular route</summary>
        /// <param name="routeId">Identifier of route; values returned by Routes API - v3/routes</param>
        /// <param name="disruptionStatus">Filter by status of disruption</param>
        /// <returns>All disruption information (if any exists) for the specified route.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public DisruptionsResponse GetDisruptionsByRoute(int routeId, DisruptionStatus2? disruptionStatus)
        {
            return Task.Run(async () => await GetDisruptionsByRouteAsync(routeId, disruptionStatus, CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <summary>View all disruptions for a particular route</summary>
        /// <param name="routeId">Identifier of route; values returned by Routes API - v3/routes</param>
        /// <param name="disruptionStatus">Filter by status of disruption</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <returns>All disruption information (if any exists) for the specified route.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async Task<DisruptionsResponse> GetDisruptionsByRouteAsync(int routeId, DisruptionStatus2? disruptionStatus, CancellationToken cancellationToken)
        {

            var urlBuilder = new StringBuilder();
            urlBuilder.Append("/v3/disruptions/route/{route_id}?");
            urlBuilder.Replace("{route_id}", Uri.EscapeDataString(routeId.ToString()));
            if (disruptionStatus != null)
                urlBuilder.Append("disruption_status=").Append(Uri.EscapeDataString(disruptionStatus.Value.ToString())).Append("&");

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
                            var result = default(DisruptionsResponse);
                            try
                            {
                                result =
                                    JsonConvert.DeserializeObject<DisruptionsResponse>(responseData);
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

                        return default(DisruptionsResponse);
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

        /// <summary>View a specific disruption</summary>
        /// <param name="disruptionId">
        ///     Identifier of disruption; values returned by Disruptions API - /v3/disruptions OR
        ///     /v3/disruptions/route/{route_id}
        /// </param>
        /// <returns>Disruption information for the specified disruption ID.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public Task<DisruptionResponse> GetDisruptionByIdAsync(long disruptionId)
        {
            return GetDisruptionByIdAsync(disruptionId, CancellationToken.None);
        }

        /// <summary>View a specific disruption</summary>
        /// <param name="disruptionId">
        ///     Identifier of disruption; values returned by Disruptions API - /v3/disruptions OR
        ///     /v3/disruptions/route/{route_id}
        /// </param>
        /// <returns>Disruption information for the specified disruption ID.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public DisruptionResponse GetDisruptionById(long disruptionId)
        {
            return Task.Run(async () => await GetDisruptionByIdAsync(disruptionId, CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <summary>View a specific disruption</summary>
        /// <param name="disruptionId">
        ///     Identifier of disruption; values returned by Disruptions API - /v3/disruptions OR
        ///     /v3/disruptions/route/{route_id}
        /// </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <returns>Disruption information for the specified disruption ID.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async Task<DisruptionResponse> GetDisruptionByIdAsync(long disruptionId, CancellationToken cancellationToken)
        {
            var urlBuilder = new StringBuilder();
            urlBuilder.Append("/v3/disruptions/{disruption_id}?");
            urlBuilder.Replace("{disruption_id}", Uri.EscapeDataString(disruptionId.ToString()));

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
                            var result = default(DisruptionResponse);
                            try
                            {
                                result =
                                    JsonConvert.DeserializeObject<DisruptionResponse>(responseData);
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

                        return default(DisruptionResponse);
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

        public DisruptionsClient(string devid, string devKey) : base(devid, devKey)
        {
        }
    }
}