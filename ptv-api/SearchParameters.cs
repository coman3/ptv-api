namespace PtvApi
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public partial class SearchParameters : System.ComponentModel.INotifyPropertyChanged
    {
        private System.Collections.ObjectModel.ObservableCollection<RouteTypes> _routeTypes;
        private double? _latitude;
        private double? _longitude;
        private double? _maxDistance;
        private bool? _includeAddresses;
        private bool? _includeOutlets;

        /// <summary>Filter by route_type; values returned via RouteTypes API (note: stops and routes are ordered by route_types specified)</summary>
        [Newtonsoft.Json.JsonProperty("route_types", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<RouteTypes> RouteTypess
        {
            get { return _routeTypes; }
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
        [Newtonsoft.Json.JsonProperty("latitude", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Latitude
        {
            get { return _latitude; }
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
        [Newtonsoft.Json.JsonProperty("longitude", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Longitude
        {
            get { return _longitude; }
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
        [Newtonsoft.Json.JsonProperty("max_distance", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MaxDistance
        {
            get { return _maxDistance; }
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
        [Newtonsoft.Json.JsonProperty("include_addresses", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IncludeAddresses
        {
            get { return _includeAddresses; }
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
        [Newtonsoft.Json.JsonProperty("include_outlets", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IncludeOutlets
        {
            get { return _includeOutlets; }
            set
            {
                if (_includeOutlets != value)
                {
                    _includeOutlets = value;
                    RaisePropertyChanged();
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static SearchParameters FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<SearchParameters>(data);
        }

        protected virtual void RaisePropertyChanged(
            [System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    }
}