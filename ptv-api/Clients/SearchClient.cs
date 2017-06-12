using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
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
    
    public class SearchClient : PtvClient
    {
        /// <summary>View stops, routes and myki ticket outlets that match the search term</summary>
        /// <param name="searchTerm">
        ///     Search text (note: if search text is numeric and/or less than 3 characters, the API will only
        ///     return routes)
        /// </param>
        /// <param name="routeTypes">
        ///     Filter by route_type; values returned via RouteTypes API (note: stops and routes are ordered
        ///     by route_types specified)
        /// </param>
        /// <param name="latitude">Filter by geographic coordinate of latitude</param>
        /// <param name="longitude">Filter by geographic coordinate of longitude</param>
        /// <param name="maxDistance">
        ///     Filter by maximum distance (in metres) from location specified via latitude and longitude
        ///     parameters
        /// </param>
        /// <param name="includeAddresses">Placeholder for future development; currently unavailable</param>
        /// <param name="includeOutlets">Indicates if outlets will be returned in response (default = true)</param>
        /// <returns>
        ///     Stops, routes and myki ticket outlets that contain the search term (note: stops and routes are ordered by
        ///     route_type by default).
        /// </returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public Task<SearchResult> SearchAsync(string searchTerm, IEnumerable<RouteTypes> routeTypes, double? latitude, double? longitude, 
            double? maxDistance, bool? includeAddresses, bool? includeOutlets)
        {
            return SearchAsync(searchTerm, routeTypes, latitude, longitude, maxDistance, includeAddresses,
                includeOutlets,  CancellationToken.None);
        }

        /// <summary>View stops, routes and myki ticket outlets that match the search term</summary>
        /// <param name="searchTerm">
        ///     Search text (note: if search text is numeric and/or less than 3 characters, the API will only
        ///     return routes)
        /// </param>
        /// <param name="routeTypes">
        ///     Filter by route_type; values returned via RouteTypes API (note: stops and routes are ordered
        ///     by route_types specified)
        /// </param>
        /// <param name="latitude">Filter by geographic coordinate of latitude</param>
        /// <param name="longitude">Filter by geographic coordinate of longitude</param>
        /// <param name="maxDistance">
        ///     Filter by maximum distance (in metres) from location specified via latitude and longitude
        ///     parameters
        /// </param>
        /// <param name="includeAddresses">Placeholder for future development; currently unavailable</param>
        /// <param name="includeOutlets">Indicates if outlets will be returned in response (default = true)</param>
        /// <returns>
        ///     Stops, routes and myki ticket outlets that contain the search term (note: stops and routes are ordered by
        ///     route_type by default).
        /// </returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public SearchResult Search(string searchTerm, IEnumerable<RouteTypes> routeTypes,
            double? latitude, double? longitude, double? maxDistance, bool? includeAddresses, bool? includeOutlets)
        {
            return Task.Run(async () => await SearchAsync(searchTerm, routeTypes, latitude, longitude, maxDistance, includeAddresses, includeOutlets, 
                CancellationToken.None)).GetAwaiter().GetResult();
        }

        /// <summary>View stops, routes and myki ticket outlets that match the search term</summary>
        /// <param name="searchTerm">
        ///     Search text (note: if search text is numeric and/or less than 3 characters, the API will only
        ///     return routes)
        /// </param>
        /// <param name="routeTypes">
        ///     Filter by route_type; values returned via RouteTypes API (note: stops and routes are ordered
        ///     by route_types specified)
        /// </param>
        /// <param name="latitude">Filter by geographic coordinate of latitude</param>
        /// <param name="longitude">Filter by geographic coordinate of longitude</param>
        /// <param name="maxDistance">
        ///     Filter by maximum distance (in metres) from location specified via latitude and longitude
        ///     parameters
        /// </param>
        /// <param name="includeAddresses">Placeholder for future development; currently unavailable</param>
        /// <param name="includeOutlets">Indicates if outlets will be returned in response (default = true)</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <returns>
        ///     Stops, routes and myki ticket outlets that contain the search term (note: stops and routes are ordered by
        ///     route_type by default).
        /// </returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async Task<SearchResult> SearchAsync(string searchTerm, IEnumerable<RouteTypes> routeTypes, double? latitude, double? longitude,
            double? maxDistance, bool? includeAddresses, bool? includeOutlets, CancellationToken cancellationToken)
        {
            if (searchTerm == null)
                throw new ArgumentNullException(nameof(searchTerm));

            var urlBuilder = new StringBuilder();
            urlBuilder.Append("/v3/search/{search_term}?");
            urlBuilder.Replace("{search_term}", Uri.EscapeDataString(searchTerm));
            if (routeTypes != null)
                urlBuilder.Append("route_types=").Append(Uri.EscapeDataString(string.Join(",", routeTypes.Select(x=> (int)x)))).Append("&");
            if (latitude != null)
                urlBuilder.Append("latitude=").Append(Uri.EscapeDataString(latitude.Value.ToString())).Append("&");
            if (longitude != null)
                urlBuilder.Append("longitude=").Append(Uri.EscapeDataString(longitude.Value.ToString())).Append("&");
            if (maxDistance != null)
                urlBuilder.Append("max_distance=").Append(Uri.EscapeDataString(maxDistance.Value.ToString())).Append("&");
            if (includeAddresses != null)
                urlBuilder.Append("include_addresses=").Append(Uri.EscapeDataString(includeAddresses.Value.ToString())).Append("&");
            if (includeOutlets != null)
                urlBuilder.Append("include_outlets=").Append(Uri.EscapeDataString(includeOutlets.Value.ToString())).Append("&");

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
                    request.RequestUri = new Uri(BaseUrl + url, UriKind.RelativeOrAbsolute);
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
                            var result = default(SearchResult);
                            try
                            {
                                result = JsonConvert.DeserializeObject<SearchResult>(responseData);
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

                        return default(SearchResult);
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

        public SearchClient(string devid, string devKey) : base(devid, devKey)
        {
        }
    }
}