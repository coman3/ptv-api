namespace PtvApi
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "10.6.6324.28497")]
    public partial class RunsClient
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

        /// <summary>View all trip/service runs for a specific route ID</summary>
        /// <param name="route_id">Identifier of route; values returned by Routes API - v3/routes.</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>All trip/service run details for the specified route ID.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<RunsResponse> ForRouteAsync(int route_id, string token, string devid,
            string signature)
        {
            return ForRouteAsync(route_id, token, devid, signature, System.Threading.CancellationToken.None);
        }

        /// <summary>View all trip/service runs for a specific route ID</summary>
        /// <param name="route_id">Identifier of route; values returned by Routes API - v3/routes.</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>All trip/service run details for the specified route ID.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public RunsResponse ForRoute(int route_id, string token, string devid, string signature)
        {
            return System.Threading.Tasks.Task
                .Run(async () => await ForRouteAsync(route_id, token, devid, signature,
                    System.Threading.CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <summary>View all trip/service runs for a specific route ID</summary>
        /// <param name="route_id">Identifier of route; values returned by Routes API - v3/routes.</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>All trip/service run details for the specified route ID.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<RunsResponse> ForRouteAsync(int route_id, string token, string devid,
            string signature, System.Threading.CancellationToken cancellationToken)
        {
            if (route_id == null)
                throw new System.ArgumentNullException("route_id");

            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl).Append("/v3/runs/route/{route_id}?");
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
                            var result_ = default(RunsResponse);
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<RunsResponse>(responseData_);
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

                        return default(RunsResponse);
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

        /// <summary>View all trip/service runs for a specific run ID</summary>
        /// <param name="run_id">Identifier of a trip/service run; values returned by Runs API - /v3/route/{route_id} and Departures API</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>All trip/service run details for the specified run ID.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<RunsResponse> ForRunAsync(int run_id, string token, string devid,
            string signature)
        {
            return ForRunAsync(run_id, token, devid, signature, System.Threading.CancellationToken.None);
        }

        /// <summary>View all trip/service runs for a specific run ID</summary>
        /// <param name="run_id">Identifier of a trip/service run; values returned by Runs API - /v3/route/{route_id} and Departures API</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>All trip/service run details for the specified run ID.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public RunsResponse ForRun(int run_id, string token, string devid, string signature)
        {
            return System.Threading.Tasks.Task
                .Run(async () => await ForRunAsync(run_id, token, devid, signature,
                    System.Threading.CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <summary>View all trip/service runs for a specific run ID</summary>
        /// <param name="run_id">Identifier of a trip/service run; values returned by Runs API - /v3/route/{route_id} and Departures API</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>All trip/service run details for the specified run ID.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<RunsResponse> ForRunAsync(int run_id, string token, string devid,
            string signature, System.Threading.CancellationToken cancellationToken)
        {
            if (run_id == null)
                throw new System.ArgumentNullException("run_id");

            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl).Append("/v3/runs/{run_id}?");
            urlBuilder_.Replace("{run_id}", System.Uri.EscapeDataString(run_id.ToString()));
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
                            var result_ = default(RunsResponse);
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<RunsResponse>(responseData_);
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

                        return default(RunsResponse);
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

        /// <summary>View the trip/service run for a specific run ID and route type</summary>
        /// <param name="run_id">Identifier of a trip/service run; values returned by Runs API - /v3/route/{route_id} and Departures API</param>
        /// <param name="route_type">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>The trip/service run details for the run ID and route type specified.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<RunResponse> ForRunAndRouteTypeAsync(int run_id, RouteTypes route_type,
            string token, string devid, string signature)
        {
            return ForRunAndRouteTypeAsync(run_id, route_type, token, devid, signature,
                System.Threading.CancellationToken.None);
        }

        /// <summary>View the trip/service run for a specific run ID and route type</summary>
        /// <param name="run_id">Identifier of a trip/service run; values returned by Runs API - /v3/route/{route_id} and Departures API</param>
        /// <param name="route_type">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>The trip/service run details for the run ID and route type specified.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public RunResponse ForRunAndRouteType(int run_id, RouteTypes route_type, string token, string devid,
            string signature)
        {
            return System.Threading.Tasks.Task.Run(async () => await ForRunAndRouteTypeAsync(run_id, route_type, token,
                devid, signature, System.Threading.CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <summary>View the trip/service run for a specific run ID and route type</summary>
        /// <param name="run_id">Identifier of a trip/service run; values returned by Runs API - /v3/route/{route_id} and Departures API</param>
        /// <param name="route_type">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The trip/service run details for the run ID and route type specified.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<RunResponse> ForRunAndRouteTypeAsync(int run_id,
            RouteTypes route_type, string token, string devid, string signature,
            System.Threading.CancellationToken cancellationToken)
        {
            if (run_id == null)
                throw new System.ArgumentNullException("run_id");

            if (route_type == null)
                throw new System.ArgumentNullException("route_type");

            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl).Append("/v3/runs/{run_id}/route_type/{route_type}?");
            urlBuilder_.Replace("{run_id}", System.Uri.EscapeDataString(run_id.ToString()));
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
                            var result_ = default(RunResponse);
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<RunResponse>(responseData_);
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

                        return default(RunResponse);
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