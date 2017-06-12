namespace PtvApi
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public partial class Departure : System.ComponentModel.INotifyPropertyChanged
    {
        private int? _stop_id;
        private int? _route_id;
        private int? _run_id;
        private int? _direction_id;
        private System.Collections.ObjectModel.ObservableCollection<int> _disruption_ids;
        private System.DateTime? _scheduled_departure_utc;
        private System.DateTime? _estimated_departure_utc;
        private bool? _at_platform;
        private string _platform_number;
        private string _flags;

        /// <summary>Stop identifier</summary>
        [Newtonsoft.Json.JsonProperty("stop_id", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Stop_id
        {
            get { return _stop_id; }
            set
            {
                if (_stop_id != value)
                {
                    _stop_id = value;
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

        /// <summary>Trip/service run identifier</summary>
        [Newtonsoft.Json.JsonProperty("run_id", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Run_id
        {
            get { return _run_id; }
            set
            {
                if (_run_id != value)
                {
                    _run_id = value;
                    RaisePropertyChanged();
                }
            }
        }

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

        /// <summary>Disruption information identifier(s)</summary>
        [Newtonsoft.Json.JsonProperty("disruption_ids", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<int> Disruption_ids
        {
            get { return _disruption_ids; }
            set
            {
                if (_disruption_ids != value)
                {
                    _disruption_ids = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Scheduled (i.e. timetabled) departure time and date in ISO 8601 UTC format</summary>
        [Newtonsoft.Json.JsonProperty("scheduled_departure_utc", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? Scheduled_departure_utc
        {
            get { return _scheduled_departure_utc; }
            set
            {
                if (_scheduled_departure_utc != value)
                {
                    _scheduled_departure_utc = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Real-time estimate of departure time and date in ISO 8601 UTC format</summary>
        [Newtonsoft.Json.JsonProperty("estimated_departure_utc", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? Estimated_departure_utc
        {
            get { return _estimated_departure_utc; }
            set
            {
                if (_estimated_departure_utc != value)
                {
                    _estimated_departure_utc = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates if the metropolitan train service is at the platform at the time of query; returns false for other modes</summary>
        [Newtonsoft.Json.JsonProperty("at_platform", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? At_platform
        {
            get { return _at_platform; }
            set
            {
                if (_at_platform != value)
                {
                    _at_platform = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Platform number at stop (metropolitan train only; returns null for other modes)</summary>
        [Newtonsoft.Json.JsonProperty("platform_number", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Platform_number
        {
            get { return _platform_number; }
            set
            {
                if (_platform_number != value)
                {
                    _platform_number = value;
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