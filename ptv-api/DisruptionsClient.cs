namespace PtvApi
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "10.6.6324.28497")]
    public partial class DisruptionsClient
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

        /// <summary>View all disruptions for all route types</summary>
        /// <param name="route_types">Filter by route_type; values returned via RouteTypes API</param>
        /// <param name="disruption_status">Filter by status of disruption</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>All disruption information for all route types.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<DisruptionsResponse> GetAllDisruptionsAsync(
            System.Collections.Generic.IEnumerable<RouteTypes> route_types, Disruption_status? disruption_status,
            string token, string devid, string signature)
        {
            return GetAllDisruptionsAsync(route_types, disruption_status, token, devid, signature,
                System.Threading.CancellationToken.None);
        }

        /// <summary>View all disruptions for all route types</summary>
        /// <param name="route_types">Filter by route_type; values returned via RouteTypes API</param>
        /// <param name="disruption_status">Filter by status of disruption</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>All disruption information for all route types.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public DisruptionsResponse GetAllDisruptions(System.Collections.Generic.IEnumerable<RouteTypes> route_types,
            Disruption_status? disruption_status, string token, string devid, string signature)
        {
            return System.Threading.Tasks.Task.Run(async () => await GetAllDisruptionsAsync(route_types,
                    disruption_status, token, devid, signature, System.Threading.CancellationToken.None)).GetAwaiter()
                .GetResult();
        }

        /// <summary>View all disruptions for all route types</summary>
        /// <param name="route_types">Filter by route_type; values returned via RouteTypes API</param>
        /// <param name="disruption_status">Filter by status of disruption</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>All disruption information for all route types.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<DisruptionsResponse> GetAllDisruptionsAsync(
            System.Collections.Generic.IEnumerable<RouteTypes> route_types, Disruption_status? disruption_status,
            string token, string devid, string signature, System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl).Append("/v3/disruptions?");
            if (route_types != null)
                foreach (var item_ in route_types)
                {
                    urlBuilder_.Append("route_types=").Append(System.Uri.EscapeDataString(item_.ToString()))
                        .Append("&");
                }
            if (disruption_status != null)
                urlBuilder_.Append("disruption_status=")
                    .Append(System.Uri.EscapeDataString(disruption_status.Value.ToString())).Append("&");
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
                            var result_ = default(DisruptionsResponse);
                            try
                            {
                                result_ =
                                    Newtonsoft.Json.JsonConvert.DeserializeObject<DisruptionsResponse>(responseData_);
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

                        return default(DisruptionsResponse);
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

        /// <summary>View all disruptions for a particular route</summary>
        /// <param name="route_id">Identifier of route; values returned by Routes API - v3/routes</param>
        /// <param name="disruption_status">Filter by status of disruption</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>All disruption information (if any exists) for the specified route.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<DisruptionsResponse> GetDisruptionsByRouteAsync(int route_id,
            Disruption_status2? disruption_status, string token, string devid, string signature)
        {
            return GetDisruptionsByRouteAsync(route_id, disruption_status, token, devid, signature,
                System.Threading.CancellationToken.None);
        }

        /// <summary>View all disruptions for a particular route</summary>
        /// <param name="route_id">Identifier of route; values returned by Routes API - v3/routes</param>
        /// <param name="disruption_status">Filter by status of disruption</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>All disruption information (if any exists) for the specified route.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public DisruptionsResponse GetDisruptionsByRoute(int route_id, Disruption_status2? disruption_status,
            string token, string devid, string signature)
        {
            return System.Threading.Tasks.Task.Run(async () => await GetDisruptionsByRouteAsync(route_id,
                    disruption_status, token, devid, signature, System.Threading.CancellationToken.None)).GetAwaiter()
                .GetResult();
        }

        /// <summary>View all disruptions for a particular route</summary>
        /// <param name="route_id">Identifier of route; values returned by Routes API - v3/routes</param>
        /// <param name="disruption_status">Filter by status of disruption</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>All disruption information (if any exists) for the specified route.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<DisruptionsResponse> GetDisruptionsByRouteAsync(int route_id,
            Disruption_status2? disruption_status, string token, string devid, string signature,
            System.Threading.CancellationToken cancellationToken)
        {
            if (route_id == null)
                throw new System.ArgumentNullException("route_id");

            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl).Append("/v3/disruptions/route/{route_id}?");
            urlBuilder_.Replace("{route_id}", System.Uri.EscapeDataString(route_id.ToString()));
            if (disruption_status != null)
                urlBuilder_.Append("disruption_status=")
                    .Append(System.Uri.EscapeDataString(disruption_status.Value.ToString())).Append("&");
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
                            var result_ = default(DisruptionsResponse);
                            try
                            {
                                result_ =
                                    Newtonsoft.Json.JsonConvert.DeserializeObject<DisruptionsResponse>(responseData_);
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

                        return default(DisruptionsResponse);
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

        /// <summary>View a specific disruption</summary>
        /// <param name="disruption_id">Identifier of disruption; values returned by Disruptions API - /v3/disruptions OR /v3/disruptions/route/{route_id}</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>Disruption information for the specified disruption ID.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<DisruptionResponse> GetDisruptionByIdAsync(long disruption_id, string token,
            string devid, string signature)
        {
            return GetDisruptionByIdAsync(disruption_id, token, devid, signature,
                System.Threading.CancellationToken.None);
        }

        /// <summary>View a specific disruption</summary>
        /// <param name="disruption_id">Identifier of disruption; values returned by Disruptions API - /v3/disruptions OR /v3/disruptions/route/{route_id}</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>Disruption information for the specified disruption ID.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public DisruptionResponse GetDisruptionById(long disruption_id, string token, string devid, string signature)
        {
            return System.Threading.Tasks.Task.Run(async () => await GetDisruptionByIdAsync(disruption_id, token, devid,
                signature, System.Threading.CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <summary>View a specific disruption</summary>
        /// <param name="disruption_id">Identifier of disruption; values returned by Disruptions API - /v3/disruptions OR /v3/disruptions/route/{route_id}</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Disruption information for the specified disruption ID.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<DisruptionResponse> GetDisruptionByIdAsync(long disruption_id,
            string token, string devid, string signature, System.Threading.CancellationToken cancellationToken)
        {
            if (disruption_id == null)
                throw new System.ArgumentNullException("disruption_id");

            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl).Append("/v3/disruptions/{disruption_id}?");
            urlBuilder_.Replace("{disruption_id}", System.Uri.EscapeDataString(disruption_id.ToString()));
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
                            var result_ = default(DisruptionResponse);
                            try
                            {
                                result_ =
                                    Newtonsoft.Json.JsonConvert.DeserializeObject<DisruptionResponse>(responseData_);
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

                        return default(DisruptionResponse);
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