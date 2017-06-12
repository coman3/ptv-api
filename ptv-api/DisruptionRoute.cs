namespace PtvApi
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public partial class DisruptionRoute : System.ComponentModel.INotifyPropertyChanged
    {
        private int? _route_type;
        private int? _route_id;
        private string _route_name;
        private string _route_number;
        private DisruptionDirection _direction;

        /// <summary>Transport mode identifier</summary>
        [Newtonsoft.Json.JsonProperty("route_type", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Route_type
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

        /// <summary>Route identifier</summary>
        [Newtonsoft.Json.JsonProperty("route_id", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Route_id
        {
            get { return _route_id; }
            set
            {
                if (_route_id != value)
                {
                    _route_id = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Name of route</summary>
        [Newtonsoft.Json.JsonProperty("route_name", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Route_name
        {
            get { return _route_name; }
            set
            {
                if (_route_name != value)
                {
                    _route_name = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Route number presented to public (i.e. not route_id)</summary>
        [Newtonsoft.Json.JsonProperty("route_number", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Route_number
        {
            get { return _route_number; }
            set
            {
                if (_route_number != value)
                {
                    _route_number = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Direction of travel relevant to a disruption (if applicable)</summary>
        [Newtonsoft.Json.JsonProperty("direction", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DisruptionDirection Direction
        {
            get { return _direction; }
            set
            {
                if (_direction != value)
                {
                    _direction = value;
                    RaisePropertyChanged();
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static DisruptionRoute FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<DisruptionRoute>(data);
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