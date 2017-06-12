namespace PtvApi
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "10.6.6324.28497")]
    public partial class StopsClient
    {
        public string BaseUrl { get; set; } = "http://timetableapi.ptv.vic.gov.au";

        partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request,
            string url);

        partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request,
            System.Text.StringBuilder urlBuilder);

        partial void ProcessResponse(System.Net.Http.HttpClient client, System.Net.Http.HttpResponseMessage response);

        /// <summary>View facilities at a specific stop (Metro and V/Line stations only)</summary>
        /// <param name="stopId">Identifier of stop; values returned by Stops API</param>
        /// <param name="routeType">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="stopLocation">Indicates if stop location information will be returned (default = false)</param>
        /// <param name="stopAmenities">Indicates if stop amenity information will be returned (default = false)</param>
        /// <param name="stopAccessibility">Indicates if stop accessibility information will be returned (default = false)</param>
        /// <param name="stopContact">Placeholder for future development; currently unavailable</param>
        /// <param name="stopTicket">Placeholder for future development; currently unavailable</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>Stop location, amenity and accessibility facility information for the specified stop (metropolitan and V/Line stations only).</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<StopResponse> StopDetailsAsync(int stopId, RouteTypes routeType,
            bool? stopLocation, bool? stopAmenities, bool? stopAccessibility, bool? stopContact, bool? stopTicket,
            string token, string devid, string signature)
        {
            return StopDetailsAsync(stopId, routeType, stopLocation, stopAmenities, stopAccessibility,
                stopContact, stopTicket, token, devid, signature, System.Threading.CancellationToken.None);
        }

        /// <summary>View facilities at a specific stop (Metro and V/Line stations only)</summary>
        /// <param name="stopId">Identifier of stop; values returned by Stops API</param>
        /// <param name="routeType">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="stopLocation">Indicates if stop location information will be returned (default = false)</param>
        /// <param name="stopAmenities">Indicates if stop amenity information will be returned (default = false)</param>
        /// <param name="stopAccessibility">Indicates if stop accessibility information will be returned (default = false)</param>
        /// <param name="stopContact">Placeholder for future development; currently unavailable</param>
        /// <param name="stopTicket">Placeholder for future development; currently unavailable</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>Stop location, amenity and accessibility facility information for the specified stop (metropolitan and V/Line stations only).</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public StopResponse StopDetails(int stopId, RouteTypes routeType, bool? stopLocation, bool? stopAmenities,
            bool? stopAccessibility, bool? stopContact, bool? stopTicket, string token, string devid,
            string signature)
        {
            return System.Threading.Tasks.Task.Run(async () => await StopDetailsAsync(stopId, routeType,
                stopLocation, stopAmenities, stopAccessibility, stopContact, stopTicket, token, devid, signature,
                System.Threading.CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <summary>View facilities at a specific stop (Metro and V/Line stations only)</summary>
        /// <param name="stopId">Identifier of stop; values returned by Stops API</param>
        /// <param name="routeType">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="stopLocation">Indicates if stop location information will be returned (default = false)</param>
        /// <param name="stopAmenities">Indicates if stop amenity information will be returned (default = false)</param>
        /// <param name="stopAccessibility">Indicates if stop accessibility information will be returned (default = false)</param>
        /// <param name="stopContact">Placeholder for future development; currently unavailable</param>
        /// <param name="stopTicket">Placeholder for future development; currently unavailable</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Stop location, amenity and accessibility facility information for the specified stop (metropolitan and V/Line stations only).</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<StopResponse> StopDetailsAsync(int stopId, RouteTypes routeType,
            bool? stopLocation, bool? stopAmenities, bool? stopAccessibility, bool? stopContact, bool? stopTicket,
            string token, string devid, string signature, System.Threading.CancellationToken cancellationToken)
        {
            if (stopId == null)
                throw new System.ArgumentNullException("stopId");

            if (routeType == null)
                throw new System.ArgumentNullException("routeType");

            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl).Append("/v3/stops/{stop_id}/route_type/{route_type}?");
            urlBuilder.Replace("{stop_id}", System.Uri.EscapeDataString(stopId.ToString()));
            urlBuilder.Replace("{route_type}", System.Uri.EscapeDataString(routeType.ToString()));
            if (stopLocation != null)
                urlBuilder.Append("stop_location=").Append(System.Uri.EscapeDataString(stopLocation.Value.ToString()))
                    .Append("&");
            if (stopAmenities != null)
                urlBuilder.Append("stop_amenities=")
                    .Append(System.Uri.EscapeDataString(stopAmenities.Value.ToString())).Append("&");
            if (stopAccessibility != null)
                urlBuilder.Append("stop_accessibility=")
                    .Append(System.Uri.EscapeDataString(stopAccessibility.Value.ToString())).Append("&");
            if (stopContact != null)
                urlBuilder.Append("stop_contact=").Append(System.Uri.EscapeDataString(stopContact.Value.ToString()))
                    .Append("&");
            if (stopTicket != null)
                urlBuilder.Append("stop_ticket=").Append(System.Uri.EscapeDataString(stopTicket.Value.ToString()))
                    .Append("&");
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
                            var result = default(StopResponse);
                            try
                            {
                                result = Newtonsoft.Json.JsonConvert.DeserializeObject<StopResponse>(responseData);
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

                        return default(StopResponse);
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

        /// <summary>View all stops on a specific route</summary>
        /// <param name="routeId">Identifier of route; values returned by Routes API - v3/routes</param>
        /// <param name="routeType">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>All stops on the specified route.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<StopsOnRouteResponse> StopsForRouteAsync(int routeId,
            RouteTypes routeType, string token, string devid, string signature)
        {
            return StopsForRouteAsync(routeId, routeType, token, devid, signature,
                System.Threading.CancellationToken.None);
        }

        /// <summary>View all stops on a specific route</summary>
        /// <param name="routeId">Identifier of route; values returned by Routes API - v3/routes</param>
        /// <param name="routeType">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>All stops on the specified route.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public StopsOnRouteResponse StopsForRoute(int routeId, RouteTypes routeType, string token, string devid,
            string signature)
        {
            return System.Threading.Tasks.Task.Run(async () => await StopsForRouteAsync(routeId, routeType, token,
                devid, signature, System.Threading.CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <summary>View all stops on a specific route</summary>
        /// <param name="routeId">Identifier of route; values returned by Routes API - v3/routes</param>
        /// <param name="routeType">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>All stops on the specified route.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<StopsOnRouteResponse> StopsForRouteAsync(int routeId,
            RouteTypes routeType, string token, string devid, string signature,
            System.Threading.CancellationToken cancellationToken)
        {
            if (routeId == null)
                throw new System.ArgumentNullException("routeId");

            if (routeType == null)
                throw new System.ArgumentNullException("routeType");

            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl).Append("/v3/stops/route/{route_id}/route_type/{route_type}?");
            urlBuilder.Replace("{route_id}", System.Uri.EscapeDataString(routeId.ToString()));
            urlBuilder.Replace("{route_type}", System.Uri.EscapeDataString(routeType.ToString()));
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
                            var result = default(StopsOnRouteResponse);
                            try
                            {
                                result =
                                    Newtonsoft.Json.JsonConvert.DeserializeObject<StopsOnRouteResponse>(responseData);
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

                        return default(StopsOnRouteResponse);
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

        /// <summary>View all stops near a specific location</summary>
        /// <param name="latitude">Geographic coordinate of latitude</param>
        /// <param name="longitude">Geographic coordinate of longitude</param>
        /// <param name="routeTypes">Filter by route_type; values returned via RouteTypes API</param>
        /// <param name="maxResults">Maximum number of results returned (default = 30)</param>
        /// <param name="maxDistance">Filter by maximum distance (in metres) from location specified via latitude and longitude parameters (default = 300)</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>All stops near the specified location.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<StopsByDistanceResponse> StopsByGeolocationAsync(double latitude,
            double longitude, System.Collections.Generic.IEnumerable<RouteTypes> routeTypes, int? maxResults,
            double? maxDistance, string token, string devid, string signature)
        {
            return StopsByGeolocationAsync(latitude, longitude, routeTypes, maxResults, maxDistance, token, devid,
                signature, System.Threading.CancellationToken.None);
        }

        /// <summary>View all stops near a specific location</summary>
        /// <param name="latitude">Geographic coordinate of latitude</param>
        /// <param name="longitude">Geographic coordinate of longitude</param>
        /// <param name="routeTypes">Filter by route_type; values returned via RouteTypes API</param>
        /// <param name="maxResults">Maximum number of results returned (default = 30)</param>
        /// <param name="maxDistance">Filter by maximum distance (in metres) from location specified via latitude and longitude parameters (default = 300)</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>All stops near the specified location.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public StopsByDistanceResponse StopsByGeolocation(double latitude, double longitude,
            System.Collections.Generic.IEnumerable<RouteTypes> routeTypes, int? maxResults, double? maxDistance,
            string token, string devid, string signature)
        {
            return System.Threading.Tasks.Task.Run(async () => await StopsByGeolocationAsync(latitude, longitude,
                routeTypes, maxResults, maxDistance, token, devid, signature,
                System.Threading.CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <summary>View all stops near a specific location</summary>
        /// <param name="latitude">Geographic coordinate of latitude</param>
        /// <param name="longitude">Geographic coordinate of longitude</param>
        /// <param name="routeTypes">Filter by route_type; values returned via RouteTypes API</param>
        /// <param name="maxResults">Maximum number of results returned (default = 30)</param>
        /// <param name="maxDistance">Filter by maximum distance (in metres) from location specified via latitude and longitude parameters (default = 300)</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>All stops near the specified location.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<StopsByDistanceResponse> StopsByGeolocationAsync(double latitude,
            double longitude, System.Collections.Generic.IEnumerable<RouteTypes> routeTypes, int? maxResults,
            double? maxDistance, string token, string devid, string signature,
            System.Threading.CancellationToken cancellationToken)
        {
            if (latitude == null)
                throw new System.ArgumentNullException("latitude");

            if (longitude == null)
                throw new System.ArgumentNullException("longitude");

            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl).Append("/v3/stops/location/{latitude},{longitude}?");
            urlBuilder.Replace("{latitude}", System.Uri.EscapeDataString(latitude.ToString()));
            urlBuilder.Replace("{longitude}", System.Uri.EscapeDataString(longitude.ToString()));
            if (routeTypes != null)
                foreach (var item in routeTypes)
                {
                    urlBuilder.Append("route_types=").Append(System.Uri.EscapeDataString(item.ToString()))
                        .Append("&");
                }
            if (maxResults != null)
                urlBuilder.Append("max_results=").Append(System.Uri.EscapeDataString(maxResults.Value.ToString()))
                    .Append("&");
            if (maxDistance != null)
                urlBuilder.Append("max_distance=").Append(System.Uri.EscapeDataString(maxDistance.Value.ToString()))
                    .Append("&");
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
                            var result = default(StopsByDistanceResponse);
                            try
                            {
                                result =
                                    Newtonsoft.Json.JsonConvert
                                        .DeserializeObject<StopsByDistanceResponse>(responseData);
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

                        return default(StopsByDistanceResponse);
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