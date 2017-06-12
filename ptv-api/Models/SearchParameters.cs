using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ptv_api.Models
{
    
    public class SearchParameters : INotifyPropertyChanged
    {
        private bool? _includeAddresses;
        private bool? _includeOutlets;
        private double? _latitude;
        private double? _longitude;
        private double? _maxDistance;
        private ObservableCollection<RouteTypes> _routeTypes;

        /// <summary>
        ///     Filter by route_type; values returned via RouteTypes API (note: stops and routes are ordered by route_types
        ///     specified)
        /// </summary>
        [JsonProperty("route_types", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public ObservableCollection<RouteTypes> RouteTypess
        {
            get => _routeTypes;
            set
            {
                if (_routeTypes != value)
                {
                    _routeTypes = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Filter by geographic coordinate of latitude</summary>
        [JsonProperty("latitude", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public double? Latitude
        {
            get => _latitude;
            set
            {
                if (_latitude != value)
                {
                    _latitude = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Filter by geographic coordinate of longitude</summary>
        [JsonProperty("longitude", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public double? Longitude
        {
            get => _longitude;
            set
            {
                if (_longitude != value)
                {
                    _longitude = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Filter by maximum distance (in metres) from location specified via latitude and longitude parameters</summary>
        [JsonProperty("max_distance", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public double? MaxDistance
        {
            get => _maxDistance;
            set
            {
                if (_maxDistance != value)
                {
                    _maxDistance = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Placeholder for future development; currently unavailable</summary>
        [JsonProperty("include_addresses", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeAddresses
        {
            get => _includeAddresses;
            set
            {
                if (_includeAddresses != value)
                {
                    _includeAddresses = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates if outlets will be returned in response (default = true)</summary>
        [JsonProperty("include_outlets", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeOutlets
        {
            get => _includeOutlets;
            set
            {
                if (_includeOutlets != value)
                {
                    _includeOutlets = value;
                    RaisePropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static SearchParameters FromJson(string data)
        {
            return JsonConvert.DeserializeObject<SearchParameters>(data);
        }

        protected virtual void RaisePropertyChanged(
            [CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}