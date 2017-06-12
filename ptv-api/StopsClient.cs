namespace PtvApi
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "10.6.6324.28497")]
    public partial class StopsClient
    {
        private string _baseUrl = "http://timetableapi.ptv.vic.gov.au";

        public string BaseUrl
        {
            get { return _baseUrl; }
            set { _baseUrl = value; }
        }

        partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request,
            string url);

        partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request,
            System.Text.StringBuilder urlBuilder);

        partial void ProcessResponse(System.Net.Http.HttpClient client, System.Net.Http.HttpResponseMessage response);

        /// <summary>View facilities at a specific stop (Metro and V/Line stations only)</summary>
        /// <param name="stop_id">Identifier of stop; values returned by Stops API</param>
        /// <param name="route_type">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="stop_location">Indicates if stop location information will be returned (default = false)</param>
        /// <param name="stop_amenities">Indicates if stop amenity information will be returned (default = false)</param>
        /// <param name="stop_accessibility">Indicates if stop accessibility information will be returned (default = false)</param>
        /// <param name="stop_contact">Placeholder for future development; currently unavailable</param>
        /// <param name="stop_ticket">Placeholder for future development; currently unavailable</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>Stop location, amenity and accessibility facility information for the specified stop (metropolitan and V/Line stations only).</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<StopResponse> StopDetailsAsync(int stop_id, RouteTypes route_type,
            bool? stop_location, bool? stop_amenities, bool? stop_accessibility, bool? stop_contact, bool? stop_ticket,
            string token, string devid, string signature)
        {
            return StopDetailsAsync(stop_id, route_type, stop_location, stop_amenities, stop_accessibility,
                stop_contact, stop_ticket, token, devid, signature, System.Threading.CancellationToken.None);
        }

        /// <summary>View facilities at a specific stop (Metro and V/Line stations only)</summary>
        /// <param name="stop_id">Identifier of stop; values returned by Stops API</param>
        /// <param name="route_type">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="stop_location">Indicates if stop location information will be returned (default = false)</param>
        /// <param name="stop_amenities">Indicates if stop amenity information will be returned (default = false)</param>
        /// <param name="stop_accessibility">Indicates if stop accessibility information will be returned (default = false)</param>
        /// <param name="stop_contact">Placeholder for future development; currently unavailable</param>
        /// <param name="stop_ticket">Placeholder for future development; currently unavailable</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>Stop location, amenity and accessibility facility information for the specified stop (metropolitan and V/Line stations only).</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public StopResponse StopDetails(int stop_id, RouteTypes route_type, bool? stop_location, bool? stop_amenities,
            bool? stop_accessibility, bool? stop_contact, bool? stop_ticket, string token, string devid,
            string signature)
        {
            return System.Threading.Tasks.Task.Run(async () => await StopDetailsAsync(stop_id, route_type,
                stop_location, stop_amenities, stop_accessibility, stop_contact, stop_ticket, token, devid, signature,
                System.Threading.CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <summary>View facilities at a specific stop (Metro and V/Line stations only)</summary>
        /// <param name="stop_id">Identifier of stop; values returned by Stops API</param>
        /// <param name="route_type">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="stop_location">Indicates if stop location information will be returned (default = false)</param>
        /// <param name="stop_amenities">Indicates if stop amenity information will be returned (default = false)</param>
        /// <param name="stop_accessibility">Indicates if stop accessibility information will be returned (default = false)</param>
        /// <param name="stop_contact">Placeholder for future development; currently unavailable</param>
        /// <param name="stop_ticket">Placeholder for future development; currently unavailable</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Stop location, amenity and accessibility facility information for the specified stop (metropolitan and V/Line stations only).</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<StopResponse> StopDetailsAsync(int stop_id, RouteTypes route_type,
            bool? stop_location, bool? stop_amenities, bool? stop_accessibility, bool? stop_contact, bool? stop_ticket,
            string token, string devid, string signature, System.Threading.CancellationToken cancellationToken)
        {
            if (stop_id == null)
                throw new System.ArgumentNullException("stop_id");

            if (route_type == null)
                throw new System.ArgumentNullException("route_type");

            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl).Append("/v3/stops/{stop_id}/route_type/{route_type}?");
            urlBuilder_.Replace("{stop_id}", System.Uri.EscapeDataString(stop_id.ToString()));
            urlBuilder_.Replace("{route_type}", System.Uri.EscapeDataString(route_type.ToString()));
            if (stop_location != null)
                urlBuilder_.Append("stop_location=").Append(System.Uri.EscapeDataString(stop_location.Value.ToString()))
                    .Append("&");
            if (stop_amenities != null)
                urlBuilder_.Append("stop_amenities=")
                    .Append(System.Uri.EscapeDataString(stop_amenities.Value.ToString())).Append("&");
            if (stop_accessibility != null)
                urlBuilder_.Append("stop_accessibility=")
                    .Append(System.Uri.EscapeDataString(stop_accessibility.Value.ToString())).Append("&");
            if (stop_contact != null)
                urlBuilder_.Append("stop_contact=").Append(System.Uri.EscapeDataString(stop_contact.Value.ToString()))
                    .Append("&");
            if (stop_ticket != null)
                urlBuilder_.Append("stop_ticket=").Append(System.Uri.EscapeDataString(stop_ticket.Value.ToString()))
                    .Append("&");
            if (token != null)
                urlBuilder_.Append("token=").Append(System.Uri.EscapeDataString(token.ToString())).Append("&");
            if (devid != null)
                urlBuilder_.Append("devid=").Append(System.Uri.EscapeDataString(devid.ToString())).Append("&");
            if (signature != null)
                urlBuilder_.Append("signature=").Append(System.Uri.EscapeDataString(signature.ToString())).Append("&");
            urlBuilder_.Length--;

            var client_ = new System.Net.Http.HttpClient();
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(
                        new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_,
                            System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    try
                    {
                        var headers_ =
                            System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;

                        ProcessResponse(client_, response_);

                        var status_ = ((int) response_.StatusCode).ToString();
                        if (status_ == "200")
                        {
                            var responseData_ = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(StopResponse);
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<StopResponse>(responseData_);
                                return result_;
                            }
                            catch (System.Exception exception)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", status_,
                                    responseData_, headers_, exception);
                            }
                        }
                        else if (status_ == "400")
                        {
                            var responseData_ = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(ErrorResponse);
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<ErrorResponse>(responseData_);
                            }
                            catch (System.Exception exception)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", status_,
                                    responseData_, headers_, exception);
                            }
                            throw new SwaggerException<ErrorResponse>("Invalid Request", status_, responseData_,
                                headers_, result_, null);
                        }
                        else if (status_ == "403")
                        {
                            var responseData_ = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(ErrorResponse);
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<ErrorResponse>(responseData_);
                            }
                            catch (System.Exception exception)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", status_,
                                    responseData_, headers_, exception);
                            }
                            throw new SwaggerException<ErrorResponse>("Access Denied", status_, responseData_, headers_,
                                result_, null);
                        }
                        else if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new SwaggerException(
                                "The HTTP status code of the response was not expected (" + (int) response_.StatusCode +
                                ").", status_, responseData_, headers_, null);
                        }

                        return default(StopResponse);
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (client_ != null)
                    client_.Dispose();
            }
        }

        /// <summary>View all stops on a specific route</summary>
        /// <param name="route_id">Identifier of route; values returned by Routes API - v3/routes</param>
        /// <param name="route_type">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>All stops on the specified route.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<StopsOnRouteResponse> StopsForRouteAsync(int route_id,
            RouteTypes route_type, string token, string devid, string signature)
        {
            return StopsForRouteAsync(route_id, route_type, token, devid, signature,
                System.Threading.CancellationToken.None);
        }

        /// <summary>View all stops on a specific route</summary>
        /// <param name="route_id">Identifier of route; values returned by Routes API - v3/routes</param>
        /// <param name="route_type">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>All stops on the specified route.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public StopsOnRouteResponse StopsForRoute(int route_id, RouteTypes route_type, string token, string devid,
            string signature)
        {
            return System.Threading.Tasks.Task.Run(async () => await StopsForRouteAsync(route_id, route_type, token,
                devid, signature, System.Threading.CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <summary>View all stops on a specific route</summary>
        /// <param name="route_id">Identifier of route; values returned by Routes API - v3/routes</param>
        /// <param name="route_type">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>All stops on the specified route.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<StopsOnRouteResponse> StopsForRouteAsync(int route_id,
            RouteTypes route_type, string token, string devid, string signature,
            System.Threading.CancellationToken cancellationToken)
        {
            if (route_id == null)
                throw new System.ArgumentNullException("route_id");

            if (route_type == null)
                throw new System.ArgumentNullException("route_type");

            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl).Append("/v3/stops/route/{route_id}/route_type/{route_type}?");
            urlBuilder_.Replace("{route_id}", System.Uri.EscapeDataString(route_id.ToString()));
            urlBuilder_.Replace("{route_type}", System.Uri.EscapeDataString(route_type.ToString()));
            if (token != null)
                urlBuilder_.Append("token=").Append(System.Uri.EscapeDataString(token.ToString())).Append("&");
            if (devid != null)
                urlBuilder_.Append("devid=").Append(System.Uri.EscapeDataString(devid.ToString())).Append("&");
            if (signature != null)
                urlBuilder_.Append("signature=").Append(System.Uri.EscapeDataString(signature.ToString())).Append("&");
            urlBuilder_.Length--;

            var client_ = new System.Net.Http.HttpClient();
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(
                        new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_,
                            System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    try
                    {
                        var headers_ =
                            System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;

                        ProcessResponse(client_, response_);

                        var status_ = ((int) response_.StatusCode).ToString();
                        if (status_ == "200")
                        {
                            var responseData_ = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(StopsOnRouteResponse);
                            try
                            {
                                result_ =
                                    Newtonsoft.Json.JsonConvert.DeserializeObject<StopsOnRouteResponse>(responseData_);
                                return result_;
                            }
                            catch (System.Exception exception)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", status_,
                                    responseData_, headers_, exception);
                            }
                        }
                        else if (status_ == "400")
                        {
                            var responseData_ = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(ErrorResponse);
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<ErrorResponse>(responseData_);
                            }
                            catch (System.Exception exception)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", status_,
                                    responseData_, headers_, exception);
                            }
                            throw new SwaggerException<ErrorResponse>("Invalid Request", status_, responseData_,
                                headers_, result_, null);
                        }
                        else if (status_ == "403")
                        {
                            var responseData_ = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(ErrorResponse);
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<ErrorResponse>(responseData_);
                            }
                            catch (System.Exception exception)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", status_,
                                    responseData_, headers_, exception);
                            }
                            throw new SwaggerException<ErrorResponse>("Access Denied", status_, responseData_, headers_,
                                result_, null);
                        }
                        else if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new SwaggerException(
                                "The HTTP status code of the response was not expected (" + (int) response_.StatusCode +
                                ").", status_, responseData_, headers_, null);
                        }

                        return default(StopsOnRouteResponse);
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (client_ != null)
                    client_.Dispose();
            }
        }

        /// <summary>View all stops near a specific location</summary>
        /// <param name="latitude">Geographic coordinate of latitude</param>
        /// <param name="longitude">Geographic coordinate of longitude</param>
        /// <param name="route_types">Filter by route_type; values returned via RouteTypes API</param>
        /// <param name="max_results">Maximum number of results returned (default = 30)</param>
        /// <param name="max_distance">Filter by maximum distance (in metres) from location specified via latitude and longitude parameters (default = 300)</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>All stops near the specified location.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<StopsByDistanceResponse> StopsByGeolocationAsync(double latitude,
            double longitude, System.Collections.Generic.IEnumerable<RouteTypes> route_types, int? max_results,
            double? max_distance, string token, string devid, string signature)
        {
            return StopsByGeolocationAsync(latitude, longitude, route_types, max_results, max_distance, token, devid,
                signature, System.Threading.CancellationToken.None);
        }

        /// <summary>View all stops near a specific location</summary>
        /// <param name="latitude">Geographic coordinate of latitude</param>
        /// <param name="longitude">Geographic coordinate of longitude</param>
        /// <param name="route_types">Filter by route_type; values returned via RouteTypes API</param>
        /// <param name="max_results">Maximum number of results returned (default = 30)</param>
        /// <param name="max_distance">Filter by maximum distance (in metres) from location specified via latitude and longitude parameters (default = 300)</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>All stops near the specified location.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public StopsByDistanceResponse StopsByGeolocation(double latitude, double longitude,
            System.Collections.Generic.IEnumerable<RouteTypes> route_types, int? max_results, double? max_distance,
            string token, string devid, string signature)
        {
            return System.Threading.Tasks.Task.Run(async () => await StopsByGeolocationAsync(latitude, longitude,
                route_types, max_results, max_distance, token, devid, signature,
                System.Threading.CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <summary>View all stops near a specific location</summary>
        /// <param name="latitude">Geographic coordinate of latitude</param>
        /// <param name="longitude">Geographic coordinate of longitude</param>
        /// <param name="route_types">Filter by route_type; values returned via RouteTypes API</param>
        /// <param name="max_results">Maximum number of results returned (default = 30)</param>
        /// <param name="max_distance">Filter by maximum distance (in metres) from location specified via latitude and longitude parameters (default = 300)</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>All stops near the specified location.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<StopsByDistanceResponse> StopsByGeolocationAsync(double latitude,
            double longitude, System.Collections.Generic.IEnumerable<RouteTypes> route_types, int? max_results,
            double? max_distance, string token, string devid, string signature,
            System.Threading.CancellationToken cancellationToken)
        {
            if (latitude == null)
                throw new System.ArgumentNullException("latitude");

            if (longitude == null)
                throw new System.ArgumentNullException("longitude");

            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl).Append("/v3/stops/location/{latitude},{longitude}?");
            urlBuilder_.Replace("{latitude}", System.Uri.EscapeDataString(latitude.ToString()));
            urlBuilder_.Replace("{longitude}", System.Uri.EscapeDataString(longitude.ToString()));
            if (route_types != null)
                foreach (var item_ in route_types)
                {
                    urlBuilder_.Append("route_types=").Append(System.Uri.EscapeDataString(item_.ToString()))
                        .Append("&");
                }
            if (max_results != null)
                urlBuilder_.Append("max_results=").Append(System.Uri.EscapeDataString(max_results.Value.ToString()))
                    .Append("&");
            if (max_distance != null)
                urlBuilder_.Append("max_distance=").Append(System.Uri.EscapeDataString(max_distance.Value.ToString()))
                    .Append("&");
            if (token != null)
                urlBuilder_.Append("token=").Append(System.Uri.EscapeDataString(token.ToString())).Append("&");
            if (devid != null)
                urlBuilder_.Append("devid=").Append(System.Uri.EscapeDataString(devid.ToString())).Append("&");
            if (signature != null)
                urlBuilder_.Append("signature=").Append(System.Uri.EscapeDataString(signature.ToString())).Append("&");
            urlBuilder_.Length--;

            var client_ = new System.Net.Http.HttpClient();
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(
                        new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_,
                            System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    try
                    {
                        var headers_ =
                            System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;

                        ProcessResponse(client_, response_);

                        var status_ = ((int) response_.StatusCode).ToString();
                        if (status_ == "200")
                        {
                            var responseData_ = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(StopsByDistanceResponse);
                            try
                            {
                                result_ =
                                    Newtonsoft.Json.JsonConvert
                                        .DeserializeObject<StopsByDistanceResponse>(responseData_);
                                return result_;
                            }
                            catch (System.Exception exception)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", status_,
                                    responseData_, headers_, exception);
                            }
                        }
                        else if (status_ == "400")
                        {
                            var responseData_ = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(ErrorResponse);
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<ErrorResponse>(responseData_);
                            }
                            catch (System.Exception exception)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", status_,
                                    responseData_, headers_, exception);
                            }
                            throw new SwaggerException<ErrorResponse>("Invalid Request", status_, responseData_,
                                headers_, result_, null);
                        }
                        else if (status_ == "403")
                        {
                            var responseData_ = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(ErrorResponse);
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<ErrorResponse>(responseData_);
                            }
                            catch (System.Exception exception)
                            {
                                throw new SwaggerException("Could not deserialize the response body.", status_,
                                    responseData_, headers_, exception);
                            }
                            throw new SwaggerException<ErrorResponse>("Access Denied", status_, responseData_, headers_,
                                result_, null);
                        }
                        else if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new SwaggerException(
                                "The HTTP status code of the response was not expected (" + (int) response_.StatusCode +
                                ").", status_, responseData_, headers_, null);
                        }

                        return default(StopsByDistanceResponse);
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (client_ != null)
                    client_.Dispose();
            }
        }

    }
}