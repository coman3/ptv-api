namespace PtvApi
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public partial class StopDetails : System.ComponentModel.INotifyPropertyChanged
    {
        private string _station_type;
        private string _station_description;
        private int? _route_type;
        private StopLocation _stop_location;
        private StopAmenityDetails _stop_amenities;
        private StopAccessibility _stop_accessibility;
        private int? _stop_id;
        private string _stop_name;

        /// <summary>Type of metropolitan train station (i.e. "Premium", "Host" or "Unstaffed" station); returns null for V/Line train</summary>
        [Newtonsoft.Json.JsonProperty("station_type", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Station_type
        {
            get { return _station_type; }
            set
            {
                if (_station_type != value)
                {
                    _station_type = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The definition applicable to the station_type; returns null for V/Line train</summary>
        [Newtonsoft.Json.JsonProperty("station_description", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Station_description
        {
            get { return _station_description; }
            set
            {
                if (_station_description != value)
                {
                    _station_description = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Transport mode identifier</summary>
        [Newtonsoft.Json.JsonProperty("route_type", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? RouteTypes
        {
            get { return _route_type; }
            set
            {
                if (_route_type != value)
                {
                    _route_type = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Location details of the stop</summary>
        [Newtonsoft.Json.JsonProperty("stop_location", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public StopLocation Stop_location
        {
            get { return _stop_location; }
            set
            {
                if (_stop_location != value)
                {
                    _stop_location = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Amenity and facility details at the stop</summary>
        [Newtonsoft.Json.JsonProperty("stop_amenities", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public StopAmenityDetails Stop_amenities
        {
            get { return _stop_amenities; }
            set
            {
                if (_stop_amenities != value)
                {
                    _stop_amenities = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Facilities relating to the accessibility of the stop</summary>
        [Newtonsoft.Json.JsonProperty("stop_accessibility", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public StopAccessibility Stop_accessibility
        {
            get { return _stop_accessibility; }
            set
            {
                if (_stop_accessibility != value)
                {
                    _stop_accessibility = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Stop identifier</summary>
        [Newtonsoft.Json.JsonProperty("stop_id", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Stop_id
        {
            get { return _stop_id; }
            set
            {
                if (_stop_id != value)
                {
                    _stop_id = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Name of stop</summary>
        [Newtonsoft.Json.JsonProperty("stop_name", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Stop_name
        {
            get { return _stop_name; }
            set
            {
                if (_stop_name != value)
                {
                    _stop_name = value;
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