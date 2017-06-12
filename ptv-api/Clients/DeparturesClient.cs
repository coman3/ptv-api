using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ptv_api.Models;
using ptv_api.Models.Responses;

namespace ptv_api.Clients
{
    [GeneratedCode("NSwag", "10.6.6324.28497")]
    public partial class DeparturesClient : PtvClient
    {
        /// <summary>View departures for all routes from a stop</summary>
        /// <param name="routeType">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="stopId">Identifier of stop; values returned by Stops API</param>
        /// <param name="platformNumbers">Filter by platform number at stop</param>
        /// <param name="directionId">
        ///     Filter by identifier of direction of travel; values returned by Directions API -
        ///     /v3/directions/route/{route_id}
        /// </param>
        /// <param name="dateUtc">Filter by the date and time of the request (ISO 8601 UTC format)</param>
        /// <param name="maxResults">Maximum number of results returned</param>
        /// <param name="gtfs">Indicates that stop_id parameter will accept "GTFS stop_id" data</param>
        /// <param name="includeCancelled">
        ///     Indicates if cancelled services (if they exist) are returned (default = false) -
        ///     metropolitan train only
        /// </param>
        /// <param name="expand">
        ///     List objects to be returned in full (i.e. expanded) - options include: all, stop, route, run,
        ///     direction, disruption
        /// </param>
        /// <returns>
        ///     Service departures from the specified stop for all routes of the specified route type; departures are
        ///     timetabled and real-time (if applicable).
        /// </returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public Task<DeparturesResponse> GetForStopAsync(RouteTypes routeType, int stopId,
            IEnumerable<int> platformNumbers, int? directionId, DateTime? dateUtc,
            int? maxResults, bool? gtfs, bool? includeCancelled,
            IEnumerable<ExpandableParameter> expand)
        {
            return GetForStopAsync(routeType, stopId, platformNumbers, directionId, dateUtc, maxResults, gtfs,
                includeCancelled, expand, CancellationToken.None);
        }

        /// <summary>View departures for all routes from a stop</summary>
        /// <param name="routeType">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="stopId">Identifier of stop; values returned by Stops API</param>
        /// <param name="platformNumbers">Filter by platform number at stop</param>
        /// <param name="directionId">
        ///     Filter by identifier of direction of travel; values returned by Directions API -
        ///     /v3/directions/route/{route_id}
        /// </param>
        /// <param name="dateUtc">Filter by the date and time of the request (ISO 8601 UTC format)</param>
        /// <param name="maxResults">Maximum number of results returned</param>
        /// <param name="gtfs">Indicates that stop_id parameter will accept "GTFS stop_id" data</param>
        /// <param name="includeCancelled">
        ///     Indicates if cancelled services (if they exist) are returned (default = false) -
        ///     metropolitan train only
        /// </param>
        /// <param name="expand">
        ///     List objects to be returned in full (i.e. expanded) - options include: all, stop, route, run,
        ///     direction, disruption
        /// </param>
        /// <returns>
        ///     Service departures from the specified stop for all routes of the specified route type; departures are
        ///     timetabled and real-time (if applicable).
        /// </returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public DeparturesResponse GetForStop(RouteTypes routeType, int stopId,
            IEnumerable<int> platformNumbers, int? directionId, DateTime? dateUtc,
            int? maxResults, bool? gtfs, bool? includeCancelled,
            IEnumerable<ExpandableParameter> expand)
        {
            return Task.Run(async () => await GetForStopAsync(routeType, stopId,
                platformNumbers, directionId, dateUtc, maxResults, gtfs, includeCancelled, expand, CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <summary>View departures for all routes from a stop</summary>
        /// <param name="routeType">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="stopId">Identifier of stop; values returned by Stops API</param>
        /// <param name="platformNumbers">Filter by platform number at stop</param>
        /// <param name="directionId">
        ///     Filter by identifier of direction of travel; values returned by Directions API -
        ///     /v3/directions/route/{route_id}
        /// </param>
        /// <param name="dateUtc">Filter by the date and time of the request (ISO 8601 UTC format)</param>
        /// <param name="maxResults">Maximum number of results returned</param>
        /// <param name="gtfs">Indicates that stop_id parameter will accept "GTFS stop_id" data</param>
        /// <param name="includeCancelled">
        ///     Indicates if cancelled services (if they exist) are returned (default = false) -
        ///     metropolitan train only
        /// </param>
        /// <param name="expand">
        ///     List objects to be returned in full (i.e. expanded) - options include: all, stop, route, run,
        ///     direction, disruption
        /// </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <returns>
        ///     Service departures from the specified stop for all routes of the specified route type; departures are
        ///     timetabled and real-time (if applicable).
        /// </returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async Task<DeparturesResponse> GetForStopAsync(RouteTypes routeType, int stopId,
            IEnumerable<int> platformNumbers, int? directionId, DateTime? dateUtc, 
            int? maxResults, bool? gtfs, bool? includeCancelled, IEnumerable<ExpandableParameter> expand, CancellationToken cancellationToken) 
        {
            var urlBuilder = new StringBuilder();
            urlBuilder.Append("/v3/departures/route_type/{route_type}/stop/{stop_id}?");
            urlBuilder.Replace("{route_type}", Uri.EscapeDataString(routeType.ToString()));
            urlBuilder.Replace("{stop_id}", Uri.EscapeDataString(stopId.ToString()));
            if (platformNumbers != null)
                foreach (var item in platformNumbers)
                    urlBuilder.Append("platform_numbers=").Append(Uri.EscapeDataString(item.ToString()))
                        .Append("&");
            if (directionId != null)
                urlBuilder.Append("direction_id=").Append(Uri.EscapeDataString(directionId.Value.ToString()))
                    .Append("&");
            if (dateUtc != null)
                urlBuilder.Append("date_utc=")
                    .Append(Uri.EscapeDataString(
                        dateUtc.Value.ToString("s", CultureInfo.InvariantCulture))).Append("&");
            if (maxResults != null)
                urlBuilder.Append("max_results=").Append(Uri.EscapeDataString(maxResults.Value.ToString()))
                    .Append("&");
            if (gtfs != null)
                urlBuilder.Append("gtfs=").Append(Uri.EscapeDataString(gtfs.Value.ToString())).Append("&");
            if (includeCancelled != null)
                urlBuilder.Append("include_cancelled=")
                    .Append(Uri.EscapeDataString(includeCancelled.Value.ToString())).Append("&");
            if (expand != null)
                foreach (var item in expand)
                    urlBuilder.Append("expand=").Append(Uri.EscapeDataString(item.ToString())).Append("&");

            var client = new HttpClient();
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    request.Method = new HttpMethod("GET");
                    request.Headers.Accept.Add(
                        new MediaTypeWithQualityHeaderValue("application/json"));

                    PrepareRequest(client, request, urlBuilder);
                    var url = urlBuilder.ToString();
                    request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                    PrepareRequest(client, request, url);

                    var response = await client.SendAsync(request,
                            HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    try
                    {
                        var headers = response.Headers.ToDictionary(h => h.Key, h => h.Value);
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
                                    JsonConvert.DeserializeObject<DeparturesResponse>(responseData);
                                return result;
                            }
                            catch (Exception exception)
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
                                result = JsonConvert.DeserializeObject<ErrorResponse>(responseData);
                            }
                            catch (Exception exception)
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
                                result = JsonConvert.DeserializeObject<ErrorResponse>(responseData);
                            }
                            catch (Exception exception)
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
                        response?.Dispose();
                    }
                }
            }
            finally
            {
                client?.Dispose();
            }
        }

        /// <summary>View departures for a specific route from a stop</summary>
        /// <param name="routeType">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="stopId">Identifier of stop; values returned by Stops API</param>
        /// <param name="routeId">Identifier of route; values returned by Routes API - v3/routes</param>
        /// <param name="directionId">
        ///     Filter by identifier of direction of travel; values returned by Directions API -
        ///     /v3/directions/route/{route_id}
        /// </param>
        /// <param name="dateUtc">Filter by the date and time of the request (ISO 8601 UTC format)</param>
        /// <param name="maxResults">Maximum number of results returned</param>
        /// <param name="gtfs">Indicates that stop_id parameter will accept "GTFS stop_id" data</param>
        /// <param name="includeCancelled">
        ///     Indicates if cancelled services (if they exist) are returned (default = false) -
        ///     metropolitan train only
        /// </param>
        /// <param name="expand">
        ///     List objects to be returned in full (i.e. expanded) - options include: all, stop, route, run,
        ///     direction, disruption
        /// </param>
        /// <returns>
        ///     Service departures from the specified stop for the specified route (and route type); departures are timetabled
        ///     and real-time (if applicable).
        /// </returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public Task<DeparturesResponse> GetForStopAndRouteAsync(RouteTypes routeType,
            int stopId, string routeId, int? directionId, DateTime? dateUtc, int? maxResults, bool? gtfs,
            bool? includeCancelled, IEnumerable<ExpandableParameter> expand)
        {
            return GetForStopAndRouteAsync(routeType, stopId, routeId, directionId, dateUtc, maxResults, gtfs, includeCancelled, expand, CancellationToken.None);
        }

        /// <summary>View departures for a specific route from a stop</summary>
        /// <param name="routeType">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="stopId">Identifier of stop; values returned by Stops API</param>
        /// <param name="routeId">Identifier of route; values returned by Routes API - v3/routes</param>
        /// <param name="directionId">
        ///     Filter by identifier of direction of travel; values returned by Directions API -
        ///     /v3/directions/route/{route_id}
        /// </param>
        /// <param name="dateUtc">Filter by the date and time of the request (ISO 8601 UTC format)</param>
        /// <param name="maxResults">Maximum number of results returned</param>
        /// <param name="gtfs">Indicates that stop_id parameter will accept "GTFS stop_id" data</param>
        /// <param name="includeCancelled">
        ///     Indicates if cancelled services (if they exist) are returned (default = false) -
        ///     metropolitan train only
        /// </param>
        /// <param name="expand">
        ///     List objects to be returned in full (i.e. expanded) - options include: all, stop, route, run,
        ///     direction, disruption
        /// </param>
        /// <returns>
        ///     Service departures from the specified stop for the specified route (and route type); departures are timetabled
        ///     and real-time (if applicable).
        /// </returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public DeparturesResponse GetForStopAndRoute(RouteTypes routeType, int stopId, string routeId,
            int? directionId, DateTime? dateUtc, int? maxResults, bool? gtfs, bool? includeCancelled, IEnumerable<ExpandableParameter> expand)
        {
            return Task.Run(async () => await GetForStopAndRouteAsync(routeType, stopId, 
                routeId, directionId, dateUtc, maxResults, gtfs, includeCancelled, expand, CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <summary>View departures for a specific route from a stop</summary>
        /// <param name="routeType">Number identifying transport mode; values returned via RouteTypes API</param>
        /// <param name="stopId">Identifier of stop; values returned by Stops API</param>
        /// <param name="routeId">Identifier of route; values returned by Routes API - v3/routes</param>
        /// <param name="directionId">
        ///     Filter by identifier of direction of travel; values returned by Directions API -
        ///     /v3/directions/route/{route_id}
        /// </param>
        /// <param name="dateUtc">Filter by the date and time of the request (ISO 8601 UTC format)</param>
        /// <param name="maxResults">Maximum number of results returned</param>
        /// <param name="gtfs">Indicates that stop_id parameter will accept "GTFS stop_id" data</param>
        /// <param name="includeCancelled">
        ///     Indicates if cancelled services (if they exist) are returned (default = false) -
        ///     metropolitan train only
        /// </param>
        /// <param name="expand">
        ///     List objects to be returned in full (i.e. expanded) - options include: all, stop, route, run,
        ///     direction, disruption
        /// </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <returns>
        ///     Service departures from the specified stop for the specified route (and route type); departures are timetabled
        ///     and real-time (if applicable).
        /// </returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async Task<DeparturesResponse> GetForStopAndRouteAsync(RouteTypes routeType,
            int stopId, string routeId, int? directionId, DateTime? dateUtc, int? maxResults, bool? gtfs,
            bool? includeCancelled, IEnumerable<ExpandableParameter> expand, CancellationToken cancellationToken)
        {
            var urlBuilder = new StringBuilder();
            urlBuilder
                .Append("/v3/departures/route_type/{route_type}/stop/{stop_id}/route/{route_id}?");
            urlBuilder.Replace("{route_type}", Uri.EscapeDataString(routeType.ToString()));
            urlBuilder.Replace("{stop_id}", Uri.EscapeDataString(stopId.ToString()));
            urlBuilder.Replace("{route_id}", Uri.EscapeDataString(routeId));
            if (directionId != null)
                urlBuilder.Append("direction_id=").Append(Uri.EscapeDataString(directionId.Value.ToString())).Append("&");
            if (dateUtc != null)
                urlBuilder.Append("date_utc=").Append(Uri.EscapeDataString(dateUtc.Value.ToString("s", CultureInfo.InvariantCulture))).Append("&");
            if (maxResults != null)
                urlBuilder.Append("max_results=").Append(Uri.EscapeDataString(maxResults.Value.ToString())).Append("&");
            if (gtfs != null)
                urlBuilder.Append("gtfs=").Append(Uri.EscapeDataString(gtfs.Value.ToString())).Append("&");
            if (includeCancelled != null)
                urlBuilder.Append("include_cancelled=").Append(Uri.EscapeDataString(includeCancelled.Value.ToString())).Append("&");
            if (expand != null)
                urlBuilder.Append("expand=").Append(Uri.EscapeDataString(string.Join(",", expand))).Append("&");

            var client = new HttpClient();
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    request.Method = new HttpMethod("GET");
                    request.Headers.Accept.Add(
                        new MediaTypeWithQualityHeaderValue("application/json"));

                    PrepareRequest(client, request, urlBuilder);
                    var url = urlBuilder.ToString();
                    request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                    PrepareRequest(client, request, url);

                    var response = await client.SendAsync(request,
                            HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    try
                    {
                        var headers =
                            response.Headers.ToDictionary(h => h.Key, h => h.Value);
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
                                    JsonConvert.DeserializeObject<DeparturesResponse>(responseData);
                                return result;
                            }
                            catch (Exception exception)
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
                                result = JsonConvert.DeserializeObject<ErrorResponse>(responseData);
                            }
                            catch (Exception exception)
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
                                result = JsonConvert.DeserializeObject<ErrorResponse>(responseData);
                            }
                            catch (Exception exception)
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
                        response?.Dispose();
                    }
                }
            }
            finally
            {
                client?.Dispose();
            }
        }

        public DeparturesClient(string devid, string devKey) : base(devid, devKey)
        {
        }
    }
}