namespace PtvApi
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public partial class DeparturesBroadParameters : System.ComponentModel.INotifyPropertyChanged
    {
        private System.Collections.ObjectModel.ObservableCollection<int> _platformNumbers;
        private int? _directionId;
        private System.DateTime? _dateUtc;
        private int? _maxResults;
        private bool? _gtfs;
        private bool? _includeCancelled;
        private System.Collections.ObjectModel.ObservableCollection<ExpandableParameter> _expand;

        /// <summary>Filter by platform number at stop</summary>
        [Newtonsoft.Json.JsonProperty("platform_numbers", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<int> PlatformNumbers
        {
            get { return _platformNumbers; }
            set
            {
                if (_platformNumbers != value)
                {
                    _platformNumbers = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Filter by identifier of direction of travel; values returned by Directions API - /v3/directions/route/{route_id}</summary>
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

        /// <summary>Filter by the date and time of the request (ISO 8601 UTC format)</summary>
        [Newtonsoft.Json.JsonProperty("date_utc", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? DateUtc
        {
            get { return _dateUtc; }
            set
            {
                if (_dateUtc != value)
                {
                    _dateUtc = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Maximum number of results returned</summary>
        [Newtonsoft.Json.JsonProperty("max_results", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? MaxResults
        {
            get { return _maxResults; }
            set
            {
                if (_maxResults != value)
                {
                    _maxResults = value;
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
        public bool? IncludeCancelled
        {
            get { return _includeCancelled; }
            set
            {
                if (_includeCancelled != value)
                {
                    _includeCancelled = value;
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