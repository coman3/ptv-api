namespace PtvApi
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "10.6.6324.28497")]
    public partial class RoutesClient
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

        /// <summary>View route names and numbers for all routes</summary>
        /// <param name="route_types">Filter by route_type; values returned via RouteTypes API</param>
        /// <param name="route_name">Filter by name  of route (accepts partial route name matches)</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>Route names and numbers for all routes of all route types.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<RouteResponse> OneOrMoreRoutesAsync(
            System.Collections.Generic.IEnumerable<RouteTypes> route_types, string route_name, string token,
            string devid, string signature)
        {
            return OneOrMoreRoutesAsync(route_types, route_name, token, devid, signature,
                System.Threading.CancellationToken.None);
        }

        /// <summary>View route names and numbers for all routes</summary>
        /// <param name="route_types">Filter by route_type; values returned via RouteTypes API</param>
        /// <param name="route_name">Filter by name  of route (accepts partial route name matches)</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>Route names and numbers for all routes of all route types.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public RouteResponse OneOrMoreRoutes(System.Collections.Generic.IEnumerable<RouteTypes> route_types,
            string route_name, string token, string devid, string signature)
        {
            return System.Threading.Tasks.Task.Run(async () => await OneOrMoreRoutesAsync(route_types, route_name,
                token, devid, signature, System.Threading.CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <summary>View route names and numbers for all routes</summary>
        /// <param name="route_types">Filter by route_type; values returned via RouteTypes API</param>
        /// <param name="route_name">Filter by name  of route (accepts partial route name matches)</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Route names and numbers for all routes of all route types.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<RouteResponse> OneOrMoreRoutesAsync(
            System.Collections.Generic.IEnumerable<RouteTypes> route_types, string route_name, string token,
            string devid, string signature, System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl).Append("/v3/routes?");
            if (route_types != null)
                foreach (var item_ in route_types)
                {
                    urlBuilder_.Append("route_types=").Append(System.Uri.EscapeDataString(item_.ToString()))
                        .Append("&");
                }
            if (route_name != null)
                urlBuilder_.Append("route_name=").Append(System.Uri.EscapeDataString(route_name.ToString()))
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
                            var result_ = default(RouteResponse);
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<RouteResponse>(responseData_);
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

                        return default(RouteResponse);
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

        /// <summary>View route name and number for specific route ID</summary>
        /// <param name="route_id">Identifier of route; values returned by Departures, Directions and Disruptions APIs</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>The route name and number for the specified route ID.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<RouteResponse> RouteFromIdAsync(int route_id, string token, string devid,
            string signature)
        {
            return RouteFromIdAsync(route_id, token, devid, signature, System.Threading.CancellationToken.None);
        }

        /// <summary>View route name and number for specific route ID</summary>
        /// <param name="route_id">Identifier of route; values returned by Departures, Directions and Disruptions APIs</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>The route name and number for the specified route ID.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public RouteResponse RouteFromId(int route_id, string token, string devid, string signature)
        {
            return System.Threading.Tasks.Task
                .Run(async () => await RouteFromIdAsync(route_id, token, devid, signature,
                    System.Threading.CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <summary>View route name and number for specific route ID</summary>
        /// <param name="route_id">Identifier of route; values returned by Departures, Directions and Disruptions APIs</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The route name and number for the specified route ID.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<RouteResponse> RouteFromIdAsync(int route_id, string token,
            string devid, string signature, System.Threading.CancellationToken cancellationToken)
        {
            if (route_id == null)
                throw new System.ArgumentNullException("route_id");

            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl).Append("/v3/routes/{route_id}?");
            urlBuilder_.Replace("{route_id}", System.Uri.EscapeDataString(route_id.ToString()));
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
                            var result_ = default(RouteResponse);
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<RouteResponse>(responseData_);
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

                        return default(RouteResponse);
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