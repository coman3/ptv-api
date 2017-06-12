namespace PtvApi
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public partial class Direction : System.ComponentModel.INotifyPropertyChanged
    {
        private int? _direction_id;
        private string _direction_name;
        private int? _route_id;
        private int? _route_type;

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

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Direction FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Direction>(data);
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