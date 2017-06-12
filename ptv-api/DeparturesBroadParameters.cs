namespace PtvApi
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public partial class DeparturesBroadParameters : System.ComponentModel.INotifyPropertyChanged
    {
        private System.Collections.ObjectModel.ObservableCollection<int> _platform_numbers;
        private int? _direction_id;
        private System.DateTime? _date_utc;
        private int? _max_results;
        private bool? _gtfs;
        private bool? _include_cancelled;
        private System.Collections.ObjectModel.ObservableCollection<ExpandableParameter> _expand;

        /// <summary>Filter by platform number at stop</summary>
        [Newtonsoft.Json.JsonProperty("platform_numbers", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<int> Platform_numbers
        {
            get { return _platform_numbers; }
            set
            {
                if (_platform_numbers != value)
                {
                    _platform_numbers = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Filter by identifier of direction of travel; values returned by Directions API - /v3/directions/route/{route_id}</summary>
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

        /// <summary>Filter by the date and time of the request (ISO 8601 UTC format)</summary>
        [Newtonsoft.Json.JsonProperty("date_utc", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? Date_utc
        {
            get { return _date_utc; }
            set
            {
                if (_date_utc != value)
                {
                    _date_utc = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Maximum number of results returned</summary>
        [Newtonsoft.Json.JsonProperty("max_results", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Max_results
        {
            get { return _max_results; }
            set
            {
                if (_max_results != value)
                {
                    _max_results = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates that stop_id parameter will accept "GTFS stop_id" data</summary>
        [Newtonsoft.Json.JsonProperty("gtfs", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Gtfs
        {
            get { return _gtfs; }
            set
            {
                if (_gtfs != value)
                {
                    _gtfs = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates if cancelled services (if they exist) are returned (default = false) - metropolitan train only</summary>
        [Newtonsoft.Json.JsonProperty("include_cancelled", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Include_cancelled
        {
            get { return _include_cancelled; }
            set
            {
                if (_include_cancelled != value)
                {
                    _include_cancelled = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>List objects to be returned in full (i.e. expanded) - options include: all, stop, route, run, direction, disruption</summary>
        [Newtonsoft.Json.JsonProperty("expand", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
            ItemConverterType = typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public System.Collections.ObjectModel.ObservableCollection<ExpandableParameter> Expand
        {
            get { return _expand; }
            set
            {
                if (_expand != value)
                {
                    _expand = value;
                    RaisePropertyChanged();
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static DeparturesBroadParameters FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<DeparturesBroadParameters>(data);
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