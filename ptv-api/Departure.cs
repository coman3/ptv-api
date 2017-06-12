namespace PtvApi
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public partial class Departure : System.ComponentModel.INotifyPropertyChanged
    {
        private int? _stopId;
        private int? _routeId;
        private int? _runId;
        private int? _directionId;
        private System.Collections.ObjectModel.ObservableCollection<int> _disruptionIds;
        private System.DateTime? _scheduledDepartureUtc;
        private System.DateTime? _estimatedDepartureUtc;
        private bool? _atPlatform;
        private string _platformNumber;
        private string _flags;

        /// <summary>Stop identifier</summary>
        [Newtonsoft.Json.JsonProperty("stop_id", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? StopId
        {
            get { return _stopId; }
            set
            {
                if (_stopId != value)
                {
                    _stopId = value;
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

        /// <summary>Trip/service run identifier</summary>
        [Newtonsoft.Json.JsonProperty("run_id", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? RunId
        {
            get { return _runId; }
            set
            {
                if (_runId != value)
                {
                    _runId = value;
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

        /// <summary>Disruption information identifier(s)</summary>
        [Newtonsoft.Json.JsonProperty("disruption_ids", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<int> DisruptionIds
        {
            get { return _disruptionIds; }
            set
            {
                if (_disruptionIds != value)
                {
                    _disruptionIds = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Scheduled (i.e. timetabled) departure time and date in ISO 8601 UTC format</summary>
        [Newtonsoft.Json.JsonProperty("scheduled_departure_utc", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? ScheduledDepartureUtc
        {
            get { return _scheduledDepartureUtc; }
            set
            {
                if (_scheduledDepartureUtc != value)
                {
                    _scheduledDepartureUtc = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Real-time estimate of departure time and date in ISO 8601 UTC format</summary>
        [Newtonsoft.Json.JsonProperty("estimated_departure_utc", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? EstimatedDepartureUtc
        {
            get { return _estimatedDepartureUtc; }
            set
            {
                if (_estimatedDepartureUtc != value)
                {
                    _estimatedDepartureUtc = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates if the metropolitan train service is at the platform at the time of query; returns false for other modes</summary>
        [Newtonsoft.Json.JsonProperty("at_platform", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? AtPlatform
        {
            get { return _atPlatform; }
            set
            {
                if (_atPlatform != value)
                {
                    _atPlatform = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Platform number at stop (metropolitan train only; returns null for other modes)</summary>
        [Newtonsoft.Json.JsonProperty("platform_number", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PlatformNumber
        {
            get { return _platformNumber; }
            set
            {
                if (_platformNumber != value)
                {
                    _platformNumber = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Flag indicating special condition for run (e.g. RR Reservations Required, GC Guaranteed Connection, DOO Drop Off Only, PUO Pick Up Only, MO Mondays only, TU Tuesdays only, WE Wednesdays only, TH Thursdays only, FR Fridays only, SS School days only; ignore E flag)</summary>
        [Newtonsoft.Json.JsonProperty("flags", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Flags
        {
            get { return _flags; }
            set
            {
                if (_flags != value)
                {
                    _flags = value;
                    RaisePropertyChanged();
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Departure FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Departure>(data);
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