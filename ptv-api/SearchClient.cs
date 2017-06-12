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
        /// <param name="searchTerm">Search text (note: if search text is numeric and/or less than 3 characters, the API will only return routes)</param>
        /// <param name="routeTypes">Filter by route_type; values returned via RouteTypes API (note: stops and routes are ordered by route_types specified)</param>
        /// <param name="latitude">Filter by geographic coordinate of latitude</param>
        /// <param name="longitude">Filter by geographic coordinate of longitude</param>
        /// <param name="maxDistance">Filter by maximum distance (in metres) from location specified via latitude and longitude parameters</param>
        /// <param name="includeAddresses">Placeholder for future development; currently unavailable</param>
        /// <param name="includeOutlets">Indicates if outlets will be returned in response (default = true)</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>Stops, routes and myki ticket outlets that contain the search term (note: stops and routes are ordered by route_type by default).</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<SearchResult> SearchAsync(string searchTerm,
            System.Collections.Generic.IEnumerable<RouteTypes> routeTypes, double? latitude, double? longitude,
            double? maxDistance, bool? includeAddresses, bool? includeOutlets, string token, string devid,
            string signature)
        {
            return SearchAsync(searchTerm, routeTypes, latitude, longitude, maxDistance, includeAddresses,
                includeOutlets, token, devid, signature, System.Threading.CancellationToken.None);
        }

        /// <summary>View stops, routes and myki ticket outlets that match the search term</summary>
        /// <param name="searchTerm">Search text (note: if search text is numeric and/or less than 3 characters, the API will only return routes)</param>
        /// <param name="routeTypes">Filter by route_type; values returned via RouteTypes API (note: stops and routes are ordered by route_types specified)</param>
        /// <param name="latitude">Filter by geographic coordinate of latitude</param>
        /// <param name="longitude">Filter by geographic coordinate of longitude</param>
        /// <param name="maxDistance">Filter by maximum distance (in metres) from location specified via latitude and longitude parameters</param>
        /// <param name="includeAddresses">Placeholder for future development; currently unavailable</param>
        /// <param name="includeOutlets">Indicates if outlets will be returned in response (default = true)</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>Stops, routes and myki ticket outlets that contain the search term (note: stops and routes are ordered by route_type by default).</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public SearchResult Search(string searchTerm, System.Collections.Generic.IEnumerable<RouteTypes> routeTypes,
            double? latitude, double? longitude, double? maxDistance, bool? includeAddresses, bool? includeOutlets,
            string token, string devid, string signature)
        {
            return System.Threading.Tasks.Task.Run(async () => await SearchAsync(searchTerm, routeTypes, latitude,
                longitude, maxDistance, includeAddresses, includeOutlets, token, devid, signature,
                System.Threading.CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <summary>View stops, routes and myki ticket outlets that match the search term</summary>
        /// <param name="searchTerm">Search text (note: if search text is numeric and/or less than 3 characters, the API will only return routes)</param>
        /// <param name="routeTypes">Filter by route_type; values returned via RouteTypes API (note: stops and routes are ordered by route_types specified)</param>
        /// <param name="latitude">Filter by geographic coordinate of latitude</param>
        /// <param name="longitude">Filter by geographic coordinate of longitude</param>
        /// <param name="maxDistance">Filter by maximum distance (in metres) from location specified via latitude and longitude parameters</param>
        /// <param name="includeAddresses">Placeholder for future development; currently unavailable</param>
        /// <param name="includeOutlets">Indicates if outlets will be returned in response (default = true)</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Stops, routes and myki ticket outlets that contain the search term (note: stops and routes are ordered by route_type by default).</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<SearchResult> SearchAsync(string searchTerm,
            System.Collections.Generic.IEnumerable<RouteTypes> routeTypes, double? latitude, double? longitude,
            double? maxDistance, bool? includeAddresses, bool? includeOutlets, string token, string devid,
            string signature, System.Threading.CancellationToken cancellationToken)
        {
            if (searchTerm == null)
                throw new System.ArgumentNullException("searchTerm");

            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl).Append("/v3/search/{search_term}?");
            urlBuilder.Replace("{search_term}", System.Uri.EscapeDataString(searchTerm.ToString()));
            if (routeTypes != null)
                foreach (var item in routeTypes)
                {
                    urlBuilder.Append("route_types=").Append(System.Uri.EscapeDataString(item.ToString()))
                        .Append("&");
                }
            if (latitude != null)
                urlBuilder.Append("latitude=").Append(System.Uri.EscapeDataString(latitude.Value.ToString()))
                    .Append("&");
            if (longitude != null)
                urlBuilder.Append("longitude=").Append(System.Uri.EscapeDataString(longitude.Value.ToString()))
                    .Append("&");
            if (maxDistance != null)
                urlBuilder.Append("max_distance=").Append(System.Uri.EscapeDataString(maxDistance.Value.ToString()))
                    .Append("&");
            if (includeAddresses != null)
                urlBuilder.Append("include_addresses=")
                    .Append(System.Uri.EscapeDataString(includeAddresses.Value.ToString())).Append("&");
            if (includeOutlets != null)
                urlBuilder.Append("include_outlets=")
                    .Append(System.Uri.EscapeDataString(includeOutlets.Value.ToString())).Append("&");
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
                            var result = default(SearchResult);
                            try
                            {
                                result = Newtonsoft.Json.JsonConvert.DeserializeObject<SearchResult>(responseData);
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

                        return default(SearchResult);
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