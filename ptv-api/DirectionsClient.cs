using System;
using System.CodeDom.Compiler;
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
    public partial class DirectionsClient : PtvClient
    {
        /// <summary>View directions that a route travels in</summary>
        /// <param name="routeId">Identifier of route; values returned by Routes API - v3/routes</param>
        /// <returns>The directions that a specified route travels in.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public Task<DirectionsResponse> ForRouteAsync(int routeId)
        {
            return ForRouteAsync(routeId, CancellationToken.None);
        }

        /// <summary>View directions that a route travels in</summary>
        /// <param name="routeId">Identifier of route; values returned by Routes API - v3/routes</param>
        /// <returns>The directions that a specified route travels in.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public DirectionsResponse ForRoute(int routeId)
        {
            return Task.Run(async () => await ForRouteAsync(routeId, CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <summary>View directions that a route travels in</summary>
        /// <param name="routeId">Identifier of route; values returned by Routes API - v3/routes</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <returns>The directions that a specified route travels in.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async Task<DirectionsResponse> ForRouteAsync(int routeId, CancellationToken cancellationToken)
        {
            var urlBuilder = new StringBuilder();
            urlBuilder.Append("/v3/directions/route/{route_id}?");
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
                            var result = default(DirectionsResponse);
                            try
                            {
                                result =
                                    JsonConvert.DeserializeObject<DirectionsResponse>(responseData);
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

                        return default(DirectionsResponse);
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

        /// <summary>View all routes for a direction of travel</summary>
        /// <param name="directionId">
        ///     Identifier of direction of travel; values returned by Directions API -
        ///     /v3/directions/route/{route_id}
        /// </param>
        /// <returns>All routes that travel in the specified direction.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public Task<DirectionsResponse> ForDirectionAsync(int directionId)
        {
            return ForDirectionAsync(directionId, CancellationToken.None);
        }

        /// <summary>View all routes for a direction of travel</summary>
        /// <param name="directionId">
        ///     Identifier of direction of travel; values returned by Directions API -
        ///     /v3/directions/route/{route_id}
        /// </param>
        /// <returns>All routes that travel in the specified direction.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public DirectionsResponse ForDirection(int directionId)
        {
            return Task.Run(async () => await ForDirectionAsync(directionId, CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <summary>View all routes for a direction of travel</summary>
        /// <param name="directionId">
        ///     Identifier of direction of travel; values returned by Directions API -
        ///     /v3/directions/route/{route_id}
        /// </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <returns>All routes that travel in the specified direction.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async Task<DirectionsResponse> ForDirectionAsync(int directionId, CancellationToken cancellationToken)
        {
            var urlBuilder = new StringBuilder();
            urlBuilder.Append("/v3/directions/{direction_id}?");
            urlBuilder.Replace("{direction_id}", Uri.EscapeDataString(directionId.ToString()));

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
                            var result = default(DirectionsResponse);
                            try
                            {
                                result =
                                    JsonConvert.DeserializeObject<DirectionsResponse>(responseData);
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

                        return default(DirectionsResponse);
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

        /// <summary>View all routes of a particular type for a direction of travel</summary>
        /// <param name="directionId">
        ///     Identifier of direction of travel; values returned by Directions API -
        ///     /v3/directions/route/{route_id}
        /// </param>
        /// <param name="routeType">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <returns>All routes of the specified route type that travel in the specified direction.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public Task<DirectionsResponse> ForDirectionAndTypeAsync(int directionId, RouteTypes routeType)
        {
            return ForDirectionAndTypeAsync(directionId, routeType, 
                CancellationToken.None);
        }

        /// <summary>View all routes of a particular type for a direction of travel</summary>
        /// <param name="directionId">
        ///     Identifier of direction of travel; values returned by Directions API -
        ///     /v3/directions/route/{route_id}
        /// </param>
        /// <param name="routeType">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <returns>All routes of the specified route type that travel in the specified direction.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public DirectionsResponse ForDirectionAndType(int directionId, RouteTypes routeType)
        {
            return Task.Run(async () => await ForDirectionAndTypeAsync(directionId, routeType, CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <summary>View all routes of a particular type for a direction of travel</summary>
        /// <param name="directionId">
        ///     Identifier of direction of travel; values returned by Directions API -
        ///     /v3/directions/route/{route_id}
        /// </param>
        /// <param name="routeType">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <returns>All routes of the specified route type that travel in the specified direction.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async Task<DirectionsResponse> ForDirectionAndTypeAsync(int directionId, RouteTypes routeType, CancellationToken cancellationToken)
        {
            var urlBuilder = new StringBuilder();
            urlBuilder.Append("/v3/directions/{direction_id}/route_type/{route_type}?");
            urlBuilder.Replace("{direction_id}", Uri.EscapeDataString(directionId.ToString()));
            urlBuilder.Replace("{route_type}", Uri.EscapeDataString(routeType.ToString()));

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
                            var result = default(DirectionsResponse);
                            try
                            {
                                result =
                                    JsonConvert.DeserializeObject<DirectionsResponse>(responseData);
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

                        return default(DirectionsResponse);
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

        public DirectionsClient(string devid, string devKey) : base(devid, devKey)
        {
        }
    }
}