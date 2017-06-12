namespace PtvApi
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public partial class DisruptionDirection : System.ComponentModel.INotifyPropertyChanged
    {
        private int? _route_direction_id;
        private int? _direction_id;
        private string _direction_name;
        private string _service_time;

        /// <summary>Route and direction of travel combination identifier</summary>
        [Newtonsoft.Json.JsonProperty("route_direction_id", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Route_direction_id
        {
            get { return _route_direction_id; }
            set
            {
                if (_route_direction_id != value)
                {
                    _route_direction_id = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Direction of travel identifier</summary>
        [Newtonsoft.Json.JsonProperty("direction_id", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Direction_id
        {
            get { return _direction_id; }
            set
            {
                if (_direction_id != value)
                {
                    _direction_id = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Name of direction of travel</summary>
        [Newtonsoft.Json.JsonProperty("direction_name", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Direction_name
        {
            get { return _direction_name; }
            set
            {
                if (_direction_name != value)
                {
                    _direction_name = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Time of service to which disruption applies, in 24 hour clock format (HH:MM:SS) AEDT/AEST; returns null if disruption applies to multiple (or no) services</summary>
        [Newtonsoft.Json.JsonProperty("service_time", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Service_time
        {
            get { return _service_time; }
            set
            {
                if (_service_time != value)
                {
                    _service_time = value;
                    RaisePropertyChanged();
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static DisruptionDirection FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<DisruptionDirection>(data);
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