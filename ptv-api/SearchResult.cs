namespace PtvApi
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public partial class SearchResult : System.ComponentModel.INotifyPropertyChanged
    {
        private System.Collections.ObjectModel.ObservableCollection<ResultStop> _stops;
        private System.Collections.ObjectModel.ObservableCollection<ResultRoute> _routes;
        private System.Collections.ObjectModel.ObservableCollection<ResultOutlet> _outlets;
        private Status _status;

        /// <summary>Train stations, tram stops, bus stops, regional coach stops or Night Bus stops</summary>
        [Newtonsoft.Json.JsonProperty("stops", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<ResultStop> Stops
        {
            get { return _stops; }
            set
            {
                if (_stops != value)
                {
                    _stops = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Train lines, tram routes, bus routes, regional coach routes, Night Bus routes</summary>
        [Newtonsoft.Json.JsonProperty("routes", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<ResultRoute> Routes
        {
            get { return _routes; }
            set
            {
                if (_routes != value)
                {
                    _routes = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>myki ticket outlets</summary>
        [Newtonsoft.Json.JsonProperty("outlets", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<ResultOutlet> Outlets
        {
            get { return _outlets; }
            set
            {
                if (_outlets != value)
                {
                    _outlets = value;
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

        public static SearchResult FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<SearchResult>(data);
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