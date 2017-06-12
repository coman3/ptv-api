namespace PtvApi
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public partial class StopOnRoute : System.ComponentModel.INotifyPropertyChanged
    {
        private string _stop_name;
        private int? _stop_id;
        private int? _route_type;
        private double? _stop_latitude;
        private double? _stop_longitude;

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

        /// <summary>Geographic coordinate of latitude at stop</summary>
        [Newtonsoft.Json.JsonProperty("stop_latitude", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Stop_latitude
        {
            get { return _stop_latitude; }
            set
            {
                if (_stop_latitude != value)
                {
                    _stop_latitude = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Geographic coordinate of longitude at stop</summary>
        [Newtonsoft.Json.JsonProperty("stop_longitude", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Stop_longitude
        {
            get { return _stop_longitude; }
            set
            {
                if (_stop_longitude != value)
                {
                    _stop_longitude = value;
                    RaisePropertyChanged();
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static StopOnRoute FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<StopOnRoute>(data);
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