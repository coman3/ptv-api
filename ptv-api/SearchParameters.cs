namespace PtvApi
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public partial class SearchParameters : System.ComponentModel.INotifyPropertyChanged
    {
        private System.Collections.ObjectModel.ObservableCollection<Anonymous9> _route_types;
        private double? _latitude;
        private double? _longitude;
        private double? _max_distance;
        private bool? _include_addresses;
        private bool? _include_outlets;

        /// <summary>Filter by route_type; values returned via RouteTypes API (note: stops and routes are ordered by route_types specified)</summary>
        [Newtonsoft.Json.JsonProperty("route_types", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<Anonymous9> Route_types
        {
            get { return _route_types; }
            set
            {
                if (_route_types != value)
                {
                    _route_types = value;
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
        public double? Max_distance
        {
            get { return _max_distance; }
            set
            {
                if (_max_distance != value)
                {
                    _max_distance = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Placeholder for future development; currently unavailable</summary>
        [Newtonsoft.Json.JsonProperty("include_addresses", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Include_addresses
        {
            get { return _include_addresses; }
            set
            {
                if (_include_addresses != value)
                {
                    _include_addresses = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates if outlets will be returned in response (default = true)</summary>
        [Newtonsoft.Json.JsonProperty("include_outlets", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Include_outlets
        {
            get { return _include_outlets; }
            set
            {
                if (_include_outlets != value)
                {
                    _include_outlets = value;
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