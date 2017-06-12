namespace PtvApi
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "10.6.6324.28497")]
    public partial class SearchClient
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

        /// <summary>View stops, routes and myki ticket outlets that match the search term</summary>
        /// <param name="search_term">Search text (note: if search text is numeric and/or less than 3 characters, the API will only return routes)</param>
        /// <param name="route_types">Filter by route_type; values returned via RouteTypes API (note: stops and routes are ordered by route_types specified)</param>
        /// <param name="latitude">Filter by geographic coordinate of latitude</param>
        /// <param name="longitude">Filter by geographic coordinate of longitude</param>
        /// <param name="max_distance">Filter by maximum distance (in metres) from location specified via latitude and longitude parameters</param>
        /// <param name="include_addresses">Placeholder for future development; currently unavailable</param>
        /// <param name="include_outlets">Indicates if outlets will be returned in response (default = true)</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>Stops, routes and myki ticket outlets that contain the search term (note: stops and routes are ordered by route_type by default).</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<SearchResult> SearchAsync(string search_term,
            System.Collections.Generic.IEnumerable<Anonymous5> route_types, double? latitude, double? longitude,
            double? max_distance, bool? include_addresses, bool? include_outlets, string token, string devid,
            string signature)
        {
            return SearchAsync(search_term, route_types, latitude, longitude, max_distance, include_addresses,
                include_outlets, token, devid, signature, System.Threading.CancellationToken.None);
        }

        /// <summary>View stops, routes and myki ticket outlets that match the search term</summary>
        /// <param name="search_term">Search text (note: if search text is numeric and/or less than 3 characters, the API will only return routes)</param>
        /// <param name="route_types">Filter by route_type; values returned via RouteTypes API (note: stops and routes are ordered by route_types specified)</param>
        /// <param name="latitude">Filter by geographic coordinate of latitude</param>
        /// <param name="longitude">Filter by geographic coordinate of longitude</param>
        /// <param name="max_distance">Filter by maximum distance (in metres) from location specified via latitude and longitude parameters</param>
        /// <param name="include_addresses">Placeholder for future development; currently unavailable</param>
        /// <param name="include_outlets">Indicates if outlets will be returned in response (default = true)</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>Stops, routes and myki ticket outlets that contain the search term (note: stops and routes are ordered by route_type by default).</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public SearchResult Search(string search_term, System.Collections.Generic.IEnumerable<Anonymous5> route_types,
            double? latitude, double? longitude, double? max_distance, bool? include_addresses, bool? include_outlets,
            string token, string devid, string signature)
        {
            return System.Threading.Tasks.Task.Run(async () => await SearchAsync(search_term, route_types, latitude,
                longitude, max_distance, include_addresses, include_outlets, token, devid, signature,
                System.Threading.CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <summary>View stops, routes and myki ticket outlets that match the search term</summary>
        /// <param name="search_term">Search text (note: if search text is numeric and/or less than 3 characters, the API will only return routes)</param>
        /// <param name="route_types">Filter by route_type; values returned via RouteTypes API (note: stops and routes are ordered by route_types specified)</param>
        /// <param name="latitude">Filter by geographic coordinate of latitude</param>
        /// <param name="longitude">Filter by geographic coordinate of longitude</param>
        /// <param name="max_distance">Filter by maximum distance (in metres) from location specified via latitude and longitude parameters</param>
        /// <param name="include_addresses">Placeholder for future development; currently unavailable</param>
        /// <param name="include_outlets">Indicates if outlets will be returned in response (default = true)</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Stops, routes and myki ticket outlets that contain the search term (note: stops and routes are ordered by route_type by default).</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<SearchResult> SearchAsync(string search_term,
            System.Collections.Generic.IEnumerable<Anonymous5> route_types, double? latitude, double? longitude,
            double? max_distance, bool? include_addresses, bool? include_outlets, string token, string devid,
            string signature, System.Threading.CancellationToken cancellationToken)
        {
            if (search_term == null)
                throw new System.ArgumentNullException("search_term");

            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl).Append("/v3/search/{search_term}?");
            urlBuilder_.Replace("{search_term}", System.Uri.EscapeDataString(search_term.ToString()));
            if (route_types != null)
                foreach (var item_ in route_types)
                {
                    urlBuilder_.Append("route_types=").Append(System.Uri.EscapeDataString(item_.ToString()))
                        .Append("&");
                }
            if (latitude != null)
                urlBuilder_.Append("latitude=").Append(System.Uri.EscapeDataString(latitude.Value.ToString()))
                    .Append("&");
            if (longitude != null)
                urlBuilder_.Append("longitude=").Append(System.Uri.EscapeDataString(longitude.Value.ToString()))
                    .Append("&");
            if (max_distance != null)
                urlBuilder_.Append("max_distance=").Append(System.Uri.EscapeDataString(max_distance.Value.ToString()))
                    .Append("&");
            if (include_addresses != null)
                urlBuilder_.Append("include_addresses=")
                    .Append(System.Uri.EscapeDataString(include_addresses.Value.ToString())).Append("&");
            if (include_outlets != null)
                urlBuilder_.Append("include_outlets=")
                    .Append(System.Uri.EscapeDataString(include_outlets.Value.ToString())).Append("&");
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
                            var result_ = default(SearchResult);
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<SearchResult>(responseData_);
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

                        return default(SearchResult);
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