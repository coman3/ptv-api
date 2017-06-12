namespace PtvApi
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public partial class RouteTypesResponse : System.ComponentModel.INotifyPropertyChanged
    {
        private System.Collections.ObjectModel.ObservableCollection<RouteType> _route_types;
        private Status _status;

        /// <summary>Transport mode identifiers</summary>
        [Newtonsoft.Json.JsonProperty("route_types", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<RouteType> RouteTypess
        {
            get { return _route_types; }
            set
            {
                if (_route_types != value)
                {
                    _route_types = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>API Status / Metadata</summary>
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Status Status
        {
            get { return _status; }
            set
            {
                if (_status != value)
                {
                    _status = value;
                    RaisePropertyChanged();
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static RouteTypesResponse FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<RouteTypesResponse>(data);
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