namespace PtvApi
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public partial class RouteType : System.ComponentModel.INotifyPropertyChanged
    {
        private string _route_type_name;
        private int? _route_type;

        /// <summary>Name of transport mode</summary>
        [Newtonsoft.Json.JsonProperty("route_type_name", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RouteTypes_name
        {
            get { return _route_type_name; }
            set
            {
                if (_route_type_name != value)
                {
                    _route_type_name = value;
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

        public static RouteType FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<RouteType>(data);
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