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
using ptv_api.Models;
using ptv_api.Models.Responses;

namespace ptv_api.Clients
{
    
    public class RoutesClient : PtvClient
    {
        /// <summary>View route names and numbers for all routes</summary>
        /// <param name="routeTypes">Filter by route_type; values returned via RouteTypes API</param>
        /// <param name="routeName">Filter by name  of route (accepts partial route name matches)</param>
        /// <returns>Route names and numbers for all routes of all route types.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public Task<RouteResponse> OneOrMoreRoutesAsync(IEnumerable<RouteTypes> routeTypes, string routeName)
        {
            return OneOrMoreRoutesAsync(routeTypes, routeName, CancellationToken.None);
        }

        /// <summary>View route names and numbers for all routes</summary>
        /// <param name="routeTypes">Filter by route_type; values returned via RouteTypes API</param>
        /// <param name="routeName">Filter by name  of route (accepts partial route name matches)</param>
        /// <returns>Route names and numbers for all routes of all route types.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public RouteResponse OneOrMoreRoutes(IEnumerable<RouteTypes> routeTypes, string routeName)
        {
            return Task.Run(async () => await OneOrMoreRoutesAsync(routeTypes, routeName, CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <summary>View route names and numbers for all routes</summary>
        /// <param name="routeTypes">Filter by route_type; values returned via RouteTypes API</param>
        /// <param name="routeName">Filter by name  of route (accepts partial route name matches)</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <returns>Route names and numbers for all routes of all route types.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async Task<RouteResponse> OneOrMoreRoutesAsync(
            IEnumerable<RouteTypes> routeTypes, string routeName, CancellationToken cancellationToken)
        {
            var urlBuilder = new StringBuilder();
            urlBuilder.Append("/v3/routes?");
            if (routeTypes != null)
                    urlBuilder.Append("route_types=").Append(Uri.EscapeDataString(string.Join(",", routeTypes))).Append("&");
            if (routeName != null)
                urlBuilder.Append("route_name=").Append(Uri.EscapeDataString(routeName)).Append("&");

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
                    request.RequestUri = new Uri(BaseUrl + url, UriKind.RelativeOrAbsolute);
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
                            var result = default(RouteResponse);
                            try
                            {
                                result = JsonConvert.DeserializeObject<RouteResponse>(responseData);
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

                        return default(RouteResponse);
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

        /// <summary>View route name and number for specific route ID</summary>
        /// <param name="routeId">Identifier of route; values returned by Departures, Directions and Disruptions APIs</param>
        /// <returns>The route name and number for the specified route ID.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public Task<RouteResponse> RouteFromIdAsync(int routeId)
        {
            return RouteFromIdAsync(routeId, CancellationToken.None);
        }

        /// <summary>View route name and number for specific route ID</summary>
        /// <param name="routeId">Identifier of route; values returned by Departures, Directions and Disruptions APIs</param>
        /// <returns>The route name and number for the specified route ID.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public RouteResponse RouteFromId(int routeId)
        {
            return Task.Run(async () => await RouteFromIdAsync(routeId, CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <summary>View route name and number for specific route ID</summary>
        /// <param name="routeId">Identifier of route; values returned by Departures, Directions and Disruptions APIs</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <returns>The route name and number for the specified route ID.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async Task<RouteResponse> RouteFromIdAsync(int routeId, CancellationToken cancellationToken)
        {

            var urlBuilder = new StringBuilder();
            urlBuilder.Append("/v3/routes/{route_id}?");
            urlBuilder.Replace("{route_id}", Uri.EscapeDataString(routeId.ToString()));

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
                    request.RequestUri = new Uri(BaseUrl + url, UriKind.RelativeOrAbsolute);
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
                            var result = default(RouteResponse);
                            try
                            {
                                result = JsonConvert.DeserializeObject<RouteResponse>(responseData);
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

                        return default(RouteResponse);
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

        public RoutesClient(string devid, string devKey) : base(devid, devKey)
        {
        }
    }
}