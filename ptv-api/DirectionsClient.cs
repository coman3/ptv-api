namespace PtvApi
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "10.6.6324.28497")]
    public partial class DirectionsClient
    {
        public string BaseUrl { get; set; } = "http://timetableapi.ptv.vic.gov.au";

        partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request,
            string url);

        partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request,
            System.Text.StringBuilder urlBuilder);

        partial void ProcessResponse(System.Net.Http.HttpClient client, System.Net.Http.HttpResponseMessage response);

        /// <summary>View directions that a route travels in</summary>
        /// <param name="routeId">Identifier of route; values returned by Routes API - v3/routes</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>The directions that a specified route travels in.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<DirectionsResponse> ForRouteAsync(int routeId, string token, string devid,
            string signature)
        {
            return ForRouteAsync(routeId, token, devid, signature, System.Threading.CancellationToken.None);
        }

        /// <summary>View directions that a route travels in</summary>
        /// <param name="routeId">Identifier of route; values returned by Routes API - v3/routes</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>The directions that a specified route travels in.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public DirectionsResponse ForRoute(int routeId, string token, string devid, string signature)
        {
            return System.Threading.Tasks.Task
                .Run(async () => await ForRouteAsync(routeId, token, devid, signature,
                    System.Threading.CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <summary>View directions that a route travels in</summary>
        /// <param name="routeId">Identifier of route; values returned by Routes API - v3/routes</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The directions that a specified route travels in.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<DirectionsResponse> ForRouteAsync(int routeId, string token,
            string devid, string signature, System.Threading.CancellationToken cancellationToken)
        {
            if (routeId == null)
                throw new System.ArgumentNullException("routeId");

            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl).Append("/v3/directions/route/{route_id}?");
            urlBuilder.Replace("{route_id}", System.Uri.EscapeDataString(routeId.ToString()));
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
                            var result = default(DirectionsResponse);
                            try
                            {
                                result =
                                    Newtonsoft.Json.JsonConvert.DeserializeObject<DirectionsResponse>(responseData);
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

        /// <summary>View all routes for a direction of travel</summary>
        /// <param name="directionId">Identifier of direction of travel; values returned by Directions API - /v3/directions/route/{route_id}</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>All routes that travel in the specified direction.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<DirectionsResponse> ForDirectionAsync(int directionId, string token,
            string devid, string signature)
        {
            return ForDirectionAsync(directionId, token, devid, signature, System.Threading.CancellationToken.None);
        }

        /// <summary>View all routes for a direction of travel</summary>
        /// <param name="directionId">Identifier of direction of travel; values returned by Directions API - /v3/directions/route/{route_id}</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>All routes that travel in the specified direction.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public DirectionsResponse ForDirection(int directionId, string token, string devid, string signature)
        {
            return System.Threading.Tasks.Task
                .Run(async () => await ForDirectionAsync(directionId, token, devid, signature,
                    System.Threading.CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <summary>View all routes for a direction of travel</summary>
        /// <param name="directionId">Identifier of direction of travel; values returned by Directions API - /v3/directions/route/{route_id}</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>All routes that travel in the specified direction.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<DirectionsResponse> ForDirectionAsync(int directionId, string token,
            string devid, string signature, System.Threading.CancellationToken cancellationToken)
        {
            if (directionId == null)
                throw new System.ArgumentNullException("directionId");

            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl).Append("/v3/directions/{direction_id}?");
            urlBuilder.Replace("{direction_id}", System.Uri.EscapeDataString(directionId.ToString()));
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
                            var result = default(DirectionsResponse);
                            try
                            {
                                result =
                                    Newtonsoft.Json.JsonConvert.DeserializeObject<DirectionsResponse>(responseData);
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
        /// <param name="directionId">Identifier of direction of travel; values returned by Directions API - /v3/directions/route/{route_id}</param>
        /// <param name="routeType">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>All routes of the specified route type that travel in the specified direction.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<DirectionsResponse> ForDirectionAndTypeAsync(int directionId,
            RouteTypes routeType, string token, string devid, string signature)
        {
            return ForDirectionAndTypeAsync(directionId, routeType, token, devid, signature,
                System.Threading.CancellationToken.None);
        }

        /// <summary>View all routes of a particular type for a direction of travel</summary>
        /// <param name="directionId">Identifier of direction of travel; values returned by Directions API - /v3/directions/route/{route_id}</param>
        /// <param name="routeType">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>All routes of the specified route type that travel in the specified direction.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public DirectionsResponse ForDirectionAndType(int directionId, RouteTypes routeType, string token,
            string devid, string signature)
        {
            return System.Threading.Tasks.Task.Run(async () => await ForDirectionAndTypeAsync(directionId, routeType,
                token, devid, signature, System.Threading.CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <summary>View all routes of a particular type for a direction of travel</summary>
        /// <param name="directionId">Identifier of direction of travel; values returned by Directions API - /v3/directions/route/{route_id}</param>
        /// <param name="routeType">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>All routes of the specified route type that travel in the specified direction.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<DirectionsResponse> ForDirectionAndTypeAsync(int directionId,
            RouteTypes routeType, string token, string devid, string signature,
            System.Threading.CancellationToken cancellationToken)
        {
            if (directionId == null)
                throw new System.ArgumentNullException("directionId");

            if (routeType == null)
                throw new System.ArgumentNullException("routeType");

            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl).Append("/v3/directions/{direction_id}/route_type/{route_type}?");
            urlBuilder.Replace("{direction_id}", System.Uri.EscapeDataString(directionId.ToString()));
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
                            var result = default(DirectionsResponse);
                            try
                            {
                                result =
                                    Newtonsoft.Json.JsonConvert.DeserializeObject<DirectionsResponse>(responseData);
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

    }
}