namespace PtvApi
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public partial class ResultRoute : System.ComponentModel.INotifyPropertyChanged
    {
        private string _route_name;
        private string _route_number;
        private int? _route_type;
        private int? _route_id;

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

        /// <summary>Route number presented to public (nb. not route_id)</summary>
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

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static ResultRoute FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultRoute>(data);
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