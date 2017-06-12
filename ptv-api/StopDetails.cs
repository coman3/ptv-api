namespace PtvApi
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public partial class StopDetails : System.ComponentModel.INotifyPropertyChanged
    {
        private string _stationType;
        private string _stationDescription;
        private int? _routeType;
        private StopLocation _stopLocation;
        private StopAmenityDetails _stopAmenities;
        private StopAccessibility _stopAccessibility;
        private int? _stopId;
        private string _stopName;

        /// <summary>Type of metropolitan train station (i.e. "Premium", "Host" or "Unstaffed" station); returns null for V/Line train</summary>
        [Newtonsoft.Json.JsonProperty("station_type", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StationType
        {
            get { return _stationType; }
            set
            {
                if (_stationType != value)
                {
                    _stationType = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The definition applicable to the station_type; returns null for V/Line train</summary>
        [Newtonsoft.Json.JsonProperty("station_description", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StationDescription
        {
            get { return _stationDescription; }
            set
            {
                if (_stationDescription != value)
                {
                    _stationDescription = value;
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

        /// <summary>Location details of the stop</summary>
        [Newtonsoft.Json.JsonProperty("stop_location", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public StopLocation StopLocation
        {
            get { return _stopLocation; }
            set
            {
                if (_stopLocation != value)
                {
                    _stopLocation = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Amenity and facility details at the stop</summary>
        [Newtonsoft.Json.JsonProperty("stop_amenities", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public StopAmenityDetails StopAmenities
        {
            get { return _stopAmenities; }
            set
            {
                if (_stopAmenities != value)
                {
                    _stopAmenities = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Facilities relating to the accessibility of the stop</summary>
        [Newtonsoft.Json.JsonProperty("stop_accessibility", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public StopAccessibility StopAccessibility
        {
            get { return _stopAccessibility; }
            set
            {
                if (_stopAccessibility != value)
                {
                    _stopAccessibility = value;
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

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static StopDetails FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<StopDetails>(data);
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