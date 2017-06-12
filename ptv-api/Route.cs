namespace PtvApi
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public partial class Route : System.ComponentModel.INotifyPropertyChanged
    {
        private int? _routeType;
        private int? _routeId;
        private string _routeName;
        private string _routeNumber;

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

        /// <summary>Route identifier</summary>
        [Newtonsoft.Json.JsonProperty("route_id", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? RouteId
        {
            get { return _routeId; }
            set
            {
                if (_routeId != value)
                {
                    _routeId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Name of route</summary>
        [Newtonsoft.Json.JsonProperty("route_name", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RouteName
        {
            get { return _routeName; }
            set
            {
                if (_routeName != value)
                {
                    _routeName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Route number presented to public (nb. not route_id)</summary>
        [Newtonsoft.Json.JsonProperty("route_number", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RouteNumber
        {
            get { return _routeNumber; }
            set
            {
                if (_routeNumber != value)
                {
                    _routeNumber = value;
                    RaisePropertyChanged();
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Route FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Route>(data);
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