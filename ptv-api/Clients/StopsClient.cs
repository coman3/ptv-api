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
    [GeneratedCode("NSwag", "10.6.6324.28497")]
    public class StopsClient : PtvClient
    {
        /// <summary>View facilities at a specific stop (Metro and V/Line stations only)</summary>
        /// <param name="stopId">Identifier of stop; values returned by Stops API</param>
        /// <param name="routeType">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="stopLocation">Indicates if stop location information will be returned (default = false)</param>
        /// <param name="stopAmenities">Indicates if stop amenity information will be returned (default = false)</param>
        /// <param name="stopAccessibility">Indicates if stop accessibility information will be returned (default = false)</param>
        /// <param name="stopContact">Placeholder for future development; currently unavailable</param>
        /// <param name="stopTicket">Placeholder for future development; currently unavailable</param>
        /// <returns>
        ///     Stop location, amenity and accessibility facility information for the specified stop (metropolitan and V/Line
        ///     stations only).
        /// </returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public Task<StopResponse> StopDetailsAsync(int stopId, RouteTypes routeType,
            bool? stopLocation, bool? stopAmenities, bool? stopAccessibility, bool? stopContact, bool? stopTicket)
        {
            return StopDetailsAsync(stopId, routeType, stopLocation, stopAmenities, stopAccessibility,
                stopContact, stopTicket, CancellationToken.None);
        }

        /// <summary>View facilities at a specific stop (Metro and V/Line stations only)</summary>
        /// <param name="stopId">Identifier of stop; values returned by Stops API</param>
        /// <param name="routeType">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="stopLocation">Indicates if stop location information will be returned (default = false)</param>
        /// <param name="stopAmenities">Indicates if stop amenity information will be returned (default = false)</param>
        /// <param name="stopAccessibility">Indicates if stop accessibility information will be returned (default = false)</param>
        /// <param name="stopContact">Placeholder for future development; currently unavailable</param>
        /// <param name="stopTicket">Placeholder for future development; currently unavailable</param>
        /// <returns>
        ///     Stop location, amenity and accessibility facility information for the specified stop (metropolitan and V/Line
        ///     stations only).
        /// </returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public StopResponse StopDetails(int stopId, RouteTypes routeType, bool? stopLocation, bool? stopAmenities,
            bool? stopAccessibility, bool? stopContact, bool? stopTicket)
        {
            return Task.Run(async () => await StopDetailsAsync(stopId, routeType,
                stopLocation, stopAmenities, stopAccessibility, stopContact, stopTicket, CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <summary>View facilities at a specific stop (Metro and V/Line stations only)</summary>
        /// <param name="stopId">Identifier of stop; values returned by Stops API</param>
        /// <param name="routeType">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="stopLocation">Indicates if stop location information will be returned (default = false)</param>
        /// <param name="stopAmenities">Indicates if stop amenity information will be returned (default = false)</param>
        /// <param name="stopAccessibility">Indicates if stop accessibility information will be returned (default = false)</param>
        /// <param name="stopContact">Placeholder for future development; currently unavailable</param>
        /// <param name="stopTicket">Placeholder for future development; currently unavailable</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <returns>
        ///     Stop location, amenity and accessibility facility information for the specified stop (metropolitan and V/Line
        ///     stations only).
        /// </returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async Task<StopResponse> StopDetailsAsync(int stopId, RouteTypes routeType,
            bool? stopLocation, bool? stopAmenities, bool? stopAccessibility, bool? stopContact, bool? stopTicket, CancellationToken cancellationToken)
        {
            var urlBuilder = new StringBuilder();
            urlBuilder.Append("/v3/stops/{stop_id}/route_type/{route_type}?");
            urlBuilder.Replace("{stop_id}", Uri.EscapeDataString(stopId.ToString()));
            urlBuilder.Replace("{route_type}", Uri.EscapeDataString(routeType.ToString()));
            if (stopLocation != null)
                urlBuilder.Append("stop_location=").Append(Uri.EscapeDataString(stopLocation.Value.ToString())).Append("&");
            if (stopAmenities != null)
                urlBuilder.Append("stop_amenities=")
                    .Append(Uri.EscapeDataString(stopAmenities.Value.ToString())).Append("&");
            if (stopAccessibility != null)
                urlBuilder.Append("stop_accessibility=")
                    .Append(Uri.EscapeDataString(stopAccessibility.Value.ToString())).Append("&");
            if (stopContact != null)
                urlBuilder.Append("stop_contact=").Append(Uri.EscapeDataString(stopContact.Value.ToString())).Append("&");
            if (stopTicket != null)
                urlBuilder.Append("stop_ticket=").Append(Uri.EscapeDataString(stopTicket.Value.ToString())).Append("&");
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
                            var result = default(StopResponse);
                            try
                            {
                                result = JsonConvert.DeserializeObject<StopResponse>(responseData);
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

                        return default(StopResponse);
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

        /// <summary>View all stops on a specific route</summary>
        /// <param name="routeId">Identifier of route; values returned by Routes API - v3/routes</param>
        /// <param name="routeType">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <returns>All stops on the specified route.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public Task<StopsOnRouteResponse> StopsForRouteAsync(int routeId, RouteTypes routeType)
        {
            return StopsForRouteAsync(routeId, routeType, CancellationToken.None);
        }

        /// <summary>View all stops on a specific route</summary>
        /// <param name="routeId">Identifier of route; values returned by Routes API - v3/routes</param>
        /// <param name="routeType">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <returns>All stops on the specified route.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public StopsOnRouteResponse StopsForRoute(int routeId, RouteTypes routeType)
        {
            return Task.Run(async () => await StopsForRouteAsync(routeId, routeType, CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <summary>View all stops on a specific route</summary>
        /// <param name="routeId">Identifier of route; values returned by Routes API - v3/routes</param>
        /// <param name="routeType">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <returns>All stops on the specified route.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async Task<StopsOnRouteResponse> StopsForRouteAsync(int routeId, RouteTypes routeType, CancellationToken cancellationToken)
        {
            var urlBuilder = new StringBuilder();
            urlBuilder.Append("/v3/stops/route/{route_id}/route_type/{route_type}?");
            urlBuilder.Replace("{route_id}", Uri.EscapeDataString(routeId.ToString()));
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
                        var headers = response.Headers.ToDictionary(h => h.Key, h => h.Value);
                        foreach (var item in response.Content.Headers)
                            headers[item.Key] = item.Value;

                        ProcessResponse(client, response);

                        var status = ((int) response.StatusCode).ToString();
                        if (status == "200")
                        {
                            var responseData = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result = default(StopsOnRouteResponse);
                            try
                            {
                                result =
                                    JsonConvert.DeserializeObject<StopsOnRouteResponse>(responseData);
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

                        return default(StopsOnRouteResponse);
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

        /// <summary>View all stops near a specific location</summary>
        /// <param name="latitude">Geographic coordinate of latitude</param>
        /// <param name="longitude">Geographic coordinate of longitude</param>
        /// <param name="routeTypes">Filter by route_type; values returned via RouteTypes API</param>
        /// <param name="maxResults">Maximum number of results returned (default = 30)</param>
        /// <param name="maxDistance">
        ///     Filter by maximum distance (in metres) from location specified via latitude and longitude
        ///     parameters (default = 300)
        /// </param>
        /// <returns>All stops near the specified location.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public Task<StopsByDistanceResponse> StopsByGeolocationAsync(double latitude,
            double longitude, IEnumerable<RouteTypes> routeTypes, int? maxResults, double? maxDistance)
        {
            return StopsByGeolocationAsync(latitude, longitude, routeTypes, maxResults, maxDistance, CancellationToken.None);
        }

        /// <summary>View all stops near a specific location</summary>
        /// <param name="latitude">Geographic coordinate of latitude</param>
        /// <param name="longitude">Geographic coordinate of longitude</param>
        /// <param name="routeTypes">Filter by route_type; values returned via RouteTypes API</param>
        /// <param name="maxResults">Maximum number of results returned (default = 30)</param>
        /// <param name="maxDistance">
        ///     Filter by maximum distance (in metres) from location specified via latitude and longitude
        ///     parameters (default = 300)
        /// </param>
        /// <returns>All stops near the specified location.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public StopsByDistanceResponse StopsByGeolocation(double latitude, double longitude,
            IEnumerable<RouteTypes> routeTypes, int? maxResults, double? maxDistance)
        {
            return Task.Run(async () => await StopsByGeolocationAsync(latitude, longitude,
                routeTypes, maxResults, maxDistance, CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <summary>View all stops near a specific location</summary>
        /// <param name="latitude">Geographic coordinate of latitude</param>
        /// <param name="longitude">Geographic coordinate of longitude</param>
        /// <param name="routeTypes">Filter by route_type; values returned via RouteTypes API</param>
        /// <param name="maxResults">Maximum number of results returned (default = 30)</param>
        /// <param name="maxDistance">
        ///     Filter by maximum distance (in metres) from location specified via latitude and longitude
        ///     parameters (default = 300)
        /// </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <returns>All stops near the specified location.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async Task<StopsByDistanceResponse> StopsByGeolocationAsync(double latitude,
            double longitude, IEnumerable<RouteTypes> routeTypes, int? maxResults, double? maxDistance, CancellationToken cancellationToken)
        {
            var urlBuilder = new StringBuilder();
            urlBuilder.Append("/v3/stops/location/{latitude},{longitude}?");
            urlBuilder.Replace("{latitude}", Uri.EscapeDataString(latitude.ToString()));
            urlBuilder.Replace("{longitude}", Uri.EscapeDataString(longitude.ToString()));
            if (routeTypes != null)
                urlBuilder.Append("route_types=").Append(Uri.EscapeDataString(string.Join(",", routeTypes))).Append("&");
            if (maxResults != null)
                urlBuilder.Append("max_results=").Append(Uri.EscapeDataString(maxResults.Value.ToString())).Append("&");
            if (maxDistance != null)
                urlBuilder.Append("max_distance=").Append(Uri.EscapeDataString(maxDistance.Value.ToString())).Append("&");

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
                            var result = default(StopsByDistanceResponse);
                            try
                            {
                                result =
                                    JsonConvert
                                        .DeserializeObject<StopsByDistanceResponse>(responseData);
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

                        return default(StopsByDistanceResponse);
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

        public StopsClient(string devid, string devKey) : base(devid, devKey)
        {
        }
    }
}