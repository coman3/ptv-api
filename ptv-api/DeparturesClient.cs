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
        /// <param name="routeType">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="stopId">Identifier of stop; values returned by Stops API</param>
        /// <param name="platformNumbers">Filter by platform number at stop</param>
        /// <param name="directionId">Filter by identifier of direction of travel; values returned by Directions API - /v3/directions/route/{route_id}</param>
        /// <param name="dateUtc">Filter by the date and time of the request (ISO 8601 UTC format)</param>
        /// <param name="maxResults">Maximum number of results returned</param>
        /// <param name="gtfs">Indicates that stop_id parameter will accept "GTFS stop_id" data</param>
        /// <param name="includeCancelled">Indicates if cancelled services (if they exist) are returned (default = false) - metropolitan train only</param>
        /// <param name="expand">List objects to be returned in full (i.e. expanded) - options include: all, stop, route, run, direction, disruption</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>Service departures from the specified stop for all routes of the specified route type; departures are timetabled and real-time (if applicable).</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<DeparturesResponse> GetForStopAsync(RouteTypes routeType, int stopId,
            System.Collections.Generic.IEnumerable<int> platformNumbers, int? directionId, System.DateTime? dateUtc,
            int? maxResults, bool? gtfs, bool? includeCancelled,
            System.Collections.Generic.IEnumerable<ExpandableParameter> expand, string token, string devid, string signature)
        {
            return GetForStopAsync(routeType, stopId, platformNumbers, directionId, dateUtc, maxResults, gtfs,
                includeCancelled, expand, token, devid, signature, System.Threading.CancellationToken.None);
        }

        /// <summary>View departures for all routes from a stop</summary>
        /// <param name="routeType">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="stopId">Identifier of stop; values returned by Stops API</param>
        /// <param name="platformNumbers">Filter by platform number at stop</param>
        /// <param name="directionId">Filter by identifier of direction of travel; values returned by Directions API - /v3/directions/route/{route_id}</param>
        /// <param name="dateUtc">Filter by the date and time of the request (ISO 8601 UTC format)</param>
        /// <param name="maxResults">Maximum number of results returned</param>
        /// <param name="gtfs">Indicates that stop_id parameter will accept "GTFS stop_id" data</param>
        /// <param name="includeCancelled">Indicates if cancelled services (if they exist) are returned (default = false) - metropolitan train only</param>
        /// <param name="expand">List objects to be returned in full (i.e. expanded) - options include: all, stop, route, run, direction, disruption</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>Service departures from the specified stop for all routes of the specified route type; departures are timetabled and real-time (if applicable).</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public DeparturesResponse GetForStop(RouteTypes routeType, int stopId,
            System.Collections.Generic.IEnumerable<int> platformNumbers, int? directionId, System.DateTime? dateUtc,
            int? maxResults, bool? gtfs, bool? includeCancelled,
            System.Collections.Generic.IEnumerable<ExpandableParameter> expand, string token, string devid, string signature)
        {
            return System.Threading.Tasks.Task.Run(async () => await GetForStopAsync(routeType, stopId,
                platformNumbers, directionId, dateUtc, maxResults, gtfs, includeCancelled, expand, token, devid,
                signature, System.Threading.CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <summary>View departures for all routes from a stop</summary>
        /// <param name="routeType">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="stopId">Identifier of stop; values returned by Stops API</param>
        /// <param name="platformNumbers">Filter by platform number at stop</param>
        /// <param name="directionId">Filter by identifier of direction of travel; values returned by Directions API - /v3/directions/route/{route_id}</param>
        /// <param name="dateUtc">Filter by the date and time of the request (ISO 8601 UTC format)</param>
        /// <param name="maxResults">Maximum number of results returned</param>
        /// <param name="gtfs">Indicates that stop_id parameter will accept "GTFS stop_id" data</param>
        /// <param name="includeCancelled">Indicates if cancelled services (if they exist) are returned (default = false) - metropolitan train only</param>
        /// <param name="expand">List objects to be returned in full (i.e. expanded) - options include: all, stop, route, run, direction, disruption</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Service departures from the specified stop for all routes of the specified route type; departures are timetabled and real-time (if applicable).</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<DeparturesResponse> GetForStopAsync(RouteTypes routeType, int stopId,
            System.Collections.Generic.IEnumerable<int> platformNumbers, int? directionId, System.DateTime? dateUtc,
            int? maxResults, bool? gtfs, bool? includeCancelled,
            System.Collections.Generic.IEnumerable<ExpandableParameter> expand, string token, string devid, string signature,
            System.Threading.CancellationToken cancellationToken)
        {
            if (routeType == null)
                throw new System.ArgumentNullException("routeType");

            if (stopId == null)
                throw new System.ArgumentNullException("stopId");

            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl).Append("/v3/departures/route_type/{route_type}/stop/{stop_id}?");
            urlBuilder.Replace("{route_type}", System.Uri.EscapeDataString(routeType.ToString()));
            urlBuilder.Replace("{stop_id}", System.Uri.EscapeDataString(stopId.ToString()));
            if (platformNumbers != null)
                foreach (var item in platformNumbers)
                {
                    urlBuilder.Append("platform_numbers=").Append(System.Uri.EscapeDataString(item.ToString()))
                        .Append("&");
                }
            if (directionId != null)
                urlBuilder.Append("direction_id=").Append(System.Uri.EscapeDataString(directionId.Value.ToString()))
                    .Append("&");
            if (dateUtc != null)
                urlBuilder.Append("date_utc=")
                    .Append(System.Uri.EscapeDataString(
                        dateUtc.Value.ToString("s", System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            if (maxResults != null)
                urlBuilder.Append("max_results=").Append(System.Uri.EscapeDataString(maxResults.Value.ToString()))
                    .Append("&");
            if (gtfs != null)
                urlBuilder.Append("gtfs=").Append(System.Uri.EscapeDataString(gtfs.Value.ToString())).Append("&");
            if (includeCancelled != null)
                urlBuilder.Append("include_cancelled=")
                    .Append(System.Uri.EscapeDataString(includeCancelled.Value.ToString())).Append("&");
            if (expand != null)
                foreach (var item in expand)
                {
                    urlBuilder.Append("expand=").Append(System.Uri.EscapeDataString(item.ToString())).Append("&");
                }
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
                            var result = default(DeparturesResponse);
                            try
                            {
                                result =
                                    Newtonsoft.Json.JsonConvert.DeserializeObject<DeparturesResponse>(responseData);
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

                        return default(DeparturesResponse);
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

        /// <summary>View departures for a specific route from a stop</summary>
        /// <param name="routeType">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="stopId">Identifier of stop; values returned by Stops API</param>
        /// <param name="routeId">Identifier of route; values returned by Routes API - v3/routes</param>
        /// <param name="directionId">Filter by identifier of direction of travel; values returned by Directions API - /v3/directions/route/{route_id}</param>
        /// <param name="dateUtc">Filter by the date and time of the request (ISO 8601 UTC format)</param>
        /// <param name="maxResults">Maximum number of results returned</param>
        /// <param name="gtfs">Indicates that stop_id parameter will accept "GTFS stop_id" data</param>
        /// <param name="includeCancelled">Indicates if cancelled services (if they exist) are returned (default = false) - metropolitan train only</param>
        /// <param name="expand">List objects to be returned in full (i.e. expanded) - options include: all, stop, route, run, direction, disruption</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>Service departures from the specified stop for the specified route (and route type); departures are timetabled and real-time (if applicable).</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<DeparturesResponse> GetForStopAndRouteAsync(RouteTypes routeType,
            int stopId, string routeId, int? directionId, System.DateTime? dateUtc, int? maxResults, bool? gtfs,
            bool? includeCancelled, System.Collections.Generic.IEnumerable<ExpandableParameter> expand, string token,
            string devid, string signature)
        {
            return GetForStopAndRouteAsync(routeType, stopId, routeId, directionId, dateUtc, maxResults, gtfs,
                includeCancelled, expand, token, devid, signature, System.Threading.CancellationToken.None);
        }

        /// <summary>View departures for a specific route from a stop</summary>
        /// <param name="routeType">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="stopId">Identifier of stop; values returned by Stops API</param>
        /// <param name="routeId">Identifier of route; values returned by Routes API - v3/routes</param>
        /// <param name="directionId">Filter by identifier of direction of travel; values returned by Directions API - /v3/directions/route/{route_id}</param>
        /// <param name="dateUtc">Filter by the date and time of the request (ISO 8601 UTC format)</param>
        /// <param name="maxResults">Maximum number of results returned</param>
        /// <param name="gtfs">Indicates that stop_id parameter will accept "GTFS stop_id" data</param>
        /// <param name="includeCancelled">Indicates if cancelled services (if they exist) are returned (default = false) - metropolitan train only</param>
        /// <param name="expand">List objects to be returned in full (i.e. expanded) - options include: all, stop, route, run, direction, disruption</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <returns>Service departures from the specified stop for the specified route (and route type); departures are timetabled and real-time (if applicable).</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public DeparturesResponse GetForStopAndRoute(RouteTypes routeType, int stopId, string routeId,
            int? directionId, System.DateTime? dateUtc, int? maxResults, bool? gtfs, bool? includeCancelled,
            System.Collections.Generic.IEnumerable<ExpandableParameter> expand, string token, string devid, string signature)
        {
            return System.Threading.Tasks.Task.Run(async () => await GetForStopAndRouteAsync(routeType, stopId,
                routeId, directionId, dateUtc, maxResults, gtfs, includeCancelled, expand, token, devid, signature,
                System.Threading.CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <summary>View departures for a specific route from a stop</summary>
        /// <param name="routeType">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="stopId">Identifier of stop; values returned by Stops API</param>
        /// <param name="routeId">Identifier of route; values returned by Routes API - v3/routes</param>
        /// <param name="directionId">Filter by identifier of direction of travel; values returned by Directions API - /v3/directions/route/{route_id}</param>
        /// <param name="dateUtc">Filter by the date and time of the request (ISO 8601 UTC format)</param>
        /// <param name="maxResults">Maximum number of results returned</param>
        /// <param name="gtfs">Indicates that stop_id parameter will accept "GTFS stop_id" data</param>
        /// <param name="includeCancelled">Indicates if cancelled services (if they exist) are returned (default = false) - metropolitan train only</param>
        /// <param name="expand">List objects to be returned in full (i.e. expanded) - options include: all, stop, route, run, direction, disruption</param>
        /// <param name="token">Please ignore</param>
        /// <param name="devid">Your developer id</param>
        /// <param name="signature">Authentication signature for request</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Service departures from the specified stop for the specified route (and route type); departures are timetabled and real-time (if applicable).</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<DeparturesResponse> GetForStopAndRouteAsync(RouteTypes routeType,
            int stopId, string routeId, int? directionId, System.DateTime? dateUtc, int? maxResults, bool? gtfs,
            bool? includeCancelled, System.Collections.Generic.IEnumerable<ExpandableParameter> expand, string token,
            string devid, string signature, System.Threading.CancellationToken cancellationToken)
        {
            if (routeType == null)
                throw new System.ArgumentNullException("routeType");

            if (stopId == null)
                throw new System.ArgumentNullException("stopId");

            if (routeId == null)
                throw new System.ArgumentNullException("routeId");

            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl)
                .Append("/v3/departures/route_type/{route_type}/stop/{stop_id}/route/{route_id}?");
            urlBuilder.Replace("{route_type}", System.Uri.EscapeDataString(routeType.ToString()));
            urlBuilder.Replace("{stop_id}", System.Uri.EscapeDataString(stopId.ToString()));
            urlBuilder.Replace("{route_id}", System.Uri.EscapeDataString(routeId.ToString()));
            if (directionId != null)
                urlBuilder.Append("direction_id=").Append(System.Uri.EscapeDataString(directionId.Value.ToString()))
                    .Append("&");
            if (dateUtc != null)
                urlBuilder.Append("date_utc=")
                    .Append(System.Uri.EscapeDataString(
                        dateUtc.Value.ToString("s", System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            if (maxResults != null)
                urlBuilder.Append("max_results=").Append(System.Uri.EscapeDataString(maxResults.Value.ToString()))
                    .Append("&");
            if (gtfs != null)
                urlBuilder.Append("gtfs=").Append(System.Uri.EscapeDataString(gtfs.Value.ToString())).Append("&");
            if (includeCancelled != null)
                urlBuilder.Append("include_cancelled=")
                    .Append(System.Uri.EscapeDataString(includeCancelled.Value.ToString())).Append("&");
            if (expand != null)
                foreach (var item in expand)
                {
                    urlBuilder.Append("expand=").Append(System.Uri.EscapeDataString(item.ToString())).Append("&");
                }
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
                            var result = default(DeparturesResponse);
                            try
                            {
                                result =
                                    Newtonsoft.Json.JsonConvert.DeserializeObject<DeparturesResponse>(responseData);
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

                        return default(DeparturesResponse);
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