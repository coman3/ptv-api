namespace PtvApi
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "10.6.6324.28497")]
    public partial class DeparturesClient
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

        /// <summary>View departures for all routes from a stop</summary>
        /// <param name="route_type">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="stop_id">Identifier of stop; values returned by Stops API</param>
        /// <param name="platform_numbers">Filter by platform number at stop</param>
        /// <param name="direction_id">Filter by identifier of direction of travel; values returned by Directions API - /v3/directions/route/{route_id}</param>
        /// <param name="date_utc">Filter by the date and time of the request (ISO 8601 UTC format)</param>
        /// <param name="max_results">Maximum number of results returned</param>
        /// <param name="gtfs">Indicates that stop_id parameter will accept "GTFS stop_id" data</param>
        /// <param name="include_cancelled">Indicates if cancelled services (if they exist) are returned (default = false) - metropolitan train only</param>
        /// <param name="expand">List objects to be returned in full (i.e. expanded) - options include: all, stop, route, run, direction, disruption</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>Service departures from the specified stop for all routes of the specified route type; departures are timetabled and real-time (if applicable).</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<DeparturesResponse> GetForStopAsync(RouteTypes route_type, int stop_id,
            System.Collections.Generic.IEnumerable<int> platform_numbers, int? direction_id, System.DateTime? date_utc,
            int? max_results, bool? gtfs, bool? include_cancelled,
            System.Collections.Generic.IEnumerable<ExpandableParameter> expand, string token, string devid, string signature)
        {
            return GetForStopAsync(route_type, stop_id, platform_numbers, direction_id, date_utc, max_results, gtfs,
                include_cancelled, expand, token, devid, signature, System.Threading.CancellationToken.None);
        }

        /// <summary>View departures for all routes from a stop</summary>
        /// <param name="route_type">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="stop_id">Identifier of stop; values returned by Stops API</param>
        /// <param name="platform_numbers">Filter by platform number at stop</param>
        /// <param name="direction_id">Filter by identifier of direction of travel; values returned by Directions API - /v3/directions/route/{route_id}</param>
        /// <param name="date_utc">Filter by the date and time of the request (ISO 8601 UTC format)</param>
        /// <param name="max_results">Maximum number of results returned</param>
        /// <param name="gtfs">Indicates that stop_id parameter will accept "GTFS stop_id" data</param>
        /// <param name="include_cancelled">Indicates if cancelled services (if they exist) are returned (default = false) - metropolitan train only</param>
        /// <param name="expand">List objects to be returned in full (i.e. expanded) - options include: all, stop, route, run, direction, disruption</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>Service departures from the specified stop for all routes of the specified route type; departures are timetabled and real-time (if applicable).</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public DeparturesResponse GetForStop(RouteTypes route_type, int stop_id,
            System.Collections.Generic.IEnumerable<int> platform_numbers, int? direction_id, System.DateTime? date_utc,
            int? max_results, bool? gtfs, bool? include_cancelled,
            System.Collections.Generic.IEnumerable<ExpandableParameter> expand, string token, string devid, string signature)
        {
            return System.Threading.Tasks.Task.Run(async () => await GetForStopAsync(route_type, stop_id,
                platform_numbers, direction_id, date_utc, max_results, gtfs, include_cancelled, expand, token, devid,
                signature, System.Threading.CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <summary>View departures for all routes from a stop</summary>
        /// <param name="route_type">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="stop_id">Identifier of stop; values returned by Stops API</param>
        /// <param name="platform_numbers">Filter by platform number at stop</param>
        /// <param name="direction_id">Filter by identifier of direction of travel; values returned by Directions API - /v3/directions/route/{route_id}</param>
        /// <param name="date_utc">Filter by the date and time of the request (ISO 8601 UTC format)</param>
        /// <param name="max_results">Maximum number of results returned</param>
        /// <param name="gtfs">Indicates that stop_id parameter will accept "GTFS stop_id" data</param>
        /// <param name="include_cancelled">Indicates if cancelled services (if they exist) are returned (default = false) - metropolitan train only</param>
        /// <param name="expand">List objects to be returned in full (i.e. expanded) - options include: all, stop, route, run, direction, disruption</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Service departures from the specified stop for all routes of the specified route type; departures are timetabled and real-time (if applicable).</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<DeparturesResponse> GetForStopAsync(RouteTypes route_type, int stop_id,
            System.Collections.Generic.IEnumerable<int> platform_numbers, int? direction_id, System.DateTime? date_utc,
            int? max_results, bool? gtfs, bool? include_cancelled,
            System.Collections.Generic.IEnumerable<ExpandableParameter> expand, string token, string devid, string signature,
            System.Threading.CancellationToken cancellationToken)
        {
            if (route_type == null)
                throw new System.ArgumentNullException("route_type");

            if (stop_id == null)
                throw new System.ArgumentNullException("stop_id");

            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl).Append("/v3/departures/route_type/{route_type}/stop/{stop_id}?");
            urlBuilder_.Replace("{route_type}", System.Uri.EscapeDataString(route_type.ToString()));
            urlBuilder_.Replace("{stop_id}", System.Uri.EscapeDataString(stop_id.ToString()));
            if (platform_numbers != null)
                foreach (var item_ in platform_numbers)
                {
                    urlBuilder_.Append("platform_numbers=").Append(System.Uri.EscapeDataString(item_.ToString()))
                        .Append("&");
                }
            if (direction_id != null)
                urlBuilder_.Append("direction_id=").Append(System.Uri.EscapeDataString(direction_id.Value.ToString()))
                    .Append("&");
            if (date_utc != null)
                urlBuilder_.Append("date_utc=")
                    .Append(System.Uri.EscapeDataString(
                        date_utc.Value.ToString("s", System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            if (max_results != null)
                urlBuilder_.Append("max_results=").Append(System.Uri.EscapeDataString(max_results.Value.ToString()))
                    .Append("&");
            if (gtfs != null)
                urlBuilder_.Append("gtfs=").Append(System.Uri.EscapeDataString(gtfs.Value.ToString())).Append("&");
            if (include_cancelled != null)
                urlBuilder_.Append("include_cancelled=")
                    .Append(System.Uri.EscapeDataString(include_cancelled.Value.ToString())).Append("&");
            if (expand != null)
                foreach (var item_ in expand)
                {
                    urlBuilder_.Append("expand=").Append(System.Uri.EscapeDataString(item_.ToString())).Append("&");
                }
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
                            var result_ = default(DeparturesResponse);
                            try
                            {
                                result_ =
                                    Newtonsoft.Json.JsonConvert.DeserializeObject<DeparturesResponse>(responseData_);
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

                        return default(DeparturesResponse);
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

        /// <summary>View departures for a specific route from a stop</summary>
        /// <param name="route_type">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="stop_id">Identifier of stop; values returned by Stops API</param>
        /// <param name="route_id">Identifier of route; values returned by Routes API - v3/routes</param>
        /// <param name="direction_id">Filter by identifier of direction of travel; values returned by Directions API - /v3/directions/route/{route_id}</param>
        /// <param name="date_utc">Filter by the date and time of the request (ISO 8601 UTC format)</param>
        /// <param name="max_results">Maximum number of results returned</param>
        /// <param name="gtfs">Indicates that stop_id parameter will accept "GTFS stop_id" data</param>
        /// <param name="include_cancelled">Indicates if cancelled services (if they exist) are returned (default = false) - metropolitan train only</param>
        /// <param name="expand">List objects to be returned in full (i.e. expanded) - options include: all, stop, route, run, direction, disruption</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>Service departures from the specified stop for the specified route (and route type); departures are timetabled and real-time (if applicable).</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<DeparturesResponse> GetForStopAndRouteAsync(RouteTypes route_type,
            int stop_id, string route_id, int? direction_id, System.DateTime? date_utc, int? max_results, bool? gtfs,
            bool? include_cancelled, System.Collections.Generic.IEnumerable<ExpandableParameter> expand, string token,
            string devid, string signature)
        {
            return GetForStopAndRouteAsync(route_type, stop_id, route_id, direction_id, date_utc, max_results, gtfs,
                include_cancelled, expand, token, devid, signature, System.Threading.CancellationToken.None);
        }

        /// <summary>View departures for a specific route from a stop</summary>
        /// <param name="route_type">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="stop_id">Identifier of stop; values returned by Stops API</param>
        /// <param name="route_id">Identifier of route; values returned by Routes API - v3/routes</param>
        /// <param name="direction_id">Filter by identifier of direction of travel; values returned by Directions API - /v3/directions/route/{route_id}</param>
        /// <param name="date_utc">Filter by the date and time of the request (ISO 8601 UTC format)</param>
        /// <param name="max_results">Maximum number of results returned</param>
        /// <param name="gtfs">Indicates that stop_id parameter will accept "GTFS stop_id" data</param>
        /// <param name="include_cancelled">Indicates if cancelled services (if they exist) are returned (default = false) - metropolitan train only</param>
        /// <param name="expand">List objects to be returned in full (i.e. expanded) - options include: all, stop, route, run, direction, disruption</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>Service departures from the specified stop for the specified route (and route type); departures are timetabled and real-time (if applicable).</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public DeparturesResponse GetForStopAndRoute(RouteTypes route_type, int stop_id, string route_id,
            int? direction_id, System.DateTime? date_utc, int? max_results, bool? gtfs, bool? include_cancelled,
            System.Collections.Generic.IEnumerable<ExpandableParameter> expand, string token, string devid, string signature)
        {
            return System.Threading.Tasks.Task.Run(async () => await GetForStopAndRouteAsync(route_type, stop_id,
                route_id, direction_id, date_utc, max_results, gtfs, include_cancelled, expand, token, devid, signature,
                System.Threading.CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <summary>View departures for a specific route from a stop</summary>
        /// <param name="route_type">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="stop_id">Identifier of stop; values returned by Stops API</param>
        /// <param name="route_id">Identifier of route; values returned by Routes API - v3/routes</param>
        /// <param name="direction_id">Filter by identifier of direction of travel; values returned by Directions API - /v3/directions/route/{route_id}</param>
        /// <param name="date_utc">Filter by the date and time of the request (ISO 8601 UTC format)</param>
        /// <param name="max_results">Maximum number of results returned</param>
        /// <param name="gtfs">Indicates that stop_id parameter will accept "GTFS stop_id" data</param>
        /// <param name="include_cancelled">Indicates if cancelled services (if they exist) are returned (default = false) - metropolitan train only</param>
        /// <param name="expand">List objects to be returned in full (i.e. expanded) - options include: all, stop, route, run, direction, disruption</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Service departures from the specified stop for the specified route (and route type); departures are timetabled and real-time (if applicable).</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<DeparturesResponse> GetForStopAndRouteAsync(RouteTypes route_type,
            int stop_id, string route_id, int? direction_id, System.DateTime? date_utc, int? max_results, bool? gtfs,
            bool? include_cancelled, System.Collections.Generic.IEnumerable<ExpandableParameter> expand, string token,
            string devid, string signature, System.Threading.CancellationToken cancellationToken)
        {
            if (route_type == null)
                throw new System.ArgumentNullException("route_type");

            if (stop_id == null)
                throw new System.ArgumentNullException("stop_id");

            if (route_id == null)
                throw new System.ArgumentNullException("route_id");

            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl)
                .Append("/v3/departures/route_type/{route_type}/stop/{stop_id}/route/{route_id}?");
            urlBuilder_.Replace("{route_type}", System.Uri.EscapeDataString(route_type.ToString()));
            urlBuilder_.Replace("{stop_id}", System.Uri.EscapeDataString(stop_id.ToString()));
            urlBuilder_.Replace("{route_id}", System.Uri.EscapeDataString(route_id.ToString()));
            if (direction_id != null)
                urlBuilder_.Append("direction_id=").Append(System.Uri.EscapeDataString(direction_id.Value.ToString()))
                    .Append("&");
            if (date_utc != null)
                urlBuilder_.Append("date_utc=")
                    .Append(System.Uri.EscapeDataString(
                        date_utc.Value.ToString("s", System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            if (max_results != null)
                urlBuilder_.Append("max_results=").Append(System.Uri.EscapeDataString(max_results.Value.ToString()))
                    .Append("&");
            if (gtfs != null)
                urlBuilder_.Append("gtfs=").Append(System.Uri.EscapeDataString(gtfs.Value.ToString())).Append("&");
            if (include_cancelled != null)
                urlBuilder_.Append("include_cancelled=")
                    .Append(System.Uri.EscapeDataString(include_cancelled.Value.ToString())).Append("&");
            if (expand != null)
                foreach (var item_ in expand)
                {
                    urlBuilder_.Append("expand=").Append(System.Uri.EscapeDataString(item_.ToString())).Append("&");
                }
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
                            var result_ = default(DeparturesResponse);
                            try
                            {
                                result_ =
                                    Newtonsoft.Json.JsonConvert.DeserializeObject<DeparturesResponse>(responseData_);
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

                        return default(DeparturesResponse);
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