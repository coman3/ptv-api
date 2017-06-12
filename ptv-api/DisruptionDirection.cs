namespace PtvApi
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public partial class DisruptionDirection : System.ComponentModel.INotifyPropertyChanged
    {
        private int? _routeDirectionId;
        private int? _directionId;
        private string _directionName;
        private string _serviceTime;

        /// <summary>Route and direction of travel combination identifier</summary>
        [Newtonsoft.Json.JsonProperty("route_direction_id", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? RouteDirectionId
        {
            get { return _routeDirectionId; }
            set
            {
                if (_routeDirectionId != value)
                {
                    _routeDirectionId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Direction of travel identifier</summary>
        [Newtonsoft.Json.JsonProperty("direction_id", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? DirectionId
        {
            get { return _directionId; }
            set
            {
                if (_directionId != value)
                {
                    _directionId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Name of direction of travel</summary>
        [Newtonsoft.Json.JsonProperty("direction_name", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DirectionName
        {
            get { return _directionName; }
            set
            {
                if (_directionName != value)
                {
                    _directionName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Time of service to which disruption applies, in 24 hour clock format (HH:MM:SS) AEDT/AEST; returns null if disruption applies to multiple (or no) services</summary>
        [Newtonsoft.Json.JsonProperty("service_time", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ServiceTime
        {
            get { return _serviceTime; }
            set
            {
                if (_serviceTime != value)
                {
                    _serviceTime = value;
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