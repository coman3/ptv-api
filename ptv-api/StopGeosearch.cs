namespace PtvApi
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public partial class StopGeosearch : System.ComponentModel.INotifyPropertyChanged
    {
        private double? _stopDistance;
        private string _stopName;
        private int? _stopId;
        private int? _routeType;
        private double? _stopLatitude;
        private double? _stopLongitude;

        /// <summary>Distance of stop from input location (in metres); returns 0 if no location is input</summary>
        [Newtonsoft.Json.JsonProperty("stop_distance", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? StopDistance
        {
            get { return _stopDistance; }
            set
            {
                if (_stopDistance != value)
                {
                    _stopDistance = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Name of stop</summary>
        [Newtonsoft.Json.JsonProperty("stop_name", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StopName
        {
            get { return _stopName; }
            set
            {
                if (_stopName != value)
                {
                    _stopName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Stop identifier</summary>
        [Newtonsoft.Json.JsonProperty("stop_id", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? StopId
        {
            get { return _stopId; }
            set
            {
                if (_stopId != value)
                {
                    _stopId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Transport mode identifier</summary>
        [Newtonsoft.Json.JsonProperty("route_type", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? RouteTypes
        {
            get { return _routeType; }
            set
            {
                if (_routeType != value)
                {
                    _routeType = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Geographic coordinate of latitude at stop</summary>
        [Newtonsoft.Json.JsonProperty("stop_latitude", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? StopLatitude
        {
            get { return _stopLatitude; }
            set
            {
                if (_stopLatitude != value)
                {
                    _stopLatitude = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Geographic coordinate of longitude at stop</summary>
        [Newtonsoft.Json.JsonProperty("stop_longitude", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? StopLongitude
        {
            get { return _stopLongitude; }
            set
            {
                if (_stopLongitude != value)
                {
                    _stopLongitude = value;
                    RaisePropertyChanged();
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static StopGeosearch FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<StopGeosearch>(data);
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