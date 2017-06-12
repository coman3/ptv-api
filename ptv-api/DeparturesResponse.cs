namespace PtvApi
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public partial class DeparturesResponse : System.ComponentModel.INotifyPropertyChanged
    {
        private System.Collections.ObjectModel.ObservableCollection<Departure> _departures;
        private System.Collections.Generic.Dictionary<string, ResultStop> _stops;
        private System.Collections.Generic.Dictionary<string, Route> _routes;
        private System.Collections.Generic.Dictionary<string, Run> _runs;
        private System.Collections.Generic.Dictionary<string, Direction> _directions;
        private System.Collections.Generic.Dictionary<string, Disruption> _disruptions;
        private Status _status;

        /// <summary>Timetabled and real-time service departures</summary>
        [Newtonsoft.Json.JsonProperty("departures", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<Departure> Departures
        {
            get { return _departures; }
            set
            {
                if (_departures != value)
                {
                    _departures = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>A train station, tram stop, bus stop, regional coach stop or Night Bus stop</summary>
        [Newtonsoft.Json.JsonProperty("stops", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.Dictionary<string, ResultStop> Stops
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
        public System.Collections.Generic.Dictionary<string, Route> Routes
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

        /// <summary>Individual trips/services of a route</summary>
        [Newtonsoft.Json.JsonProperty("runs", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.Dictionary<string, Run> Runs
        {
            get { return _runs; }
            set
            {
                if (_runs != value)
                {
                    _runs = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Directions of travel of route</summary>
        [Newtonsoft.Json.JsonProperty("directions", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.Dictionary<string, Direction> Directions
        {
            get { return _directions; }
            set
            {
                if (_directions != value)
                {
                    _directions = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Disruption information applicable to relevant routes or stops</summary>
        [Newtonsoft.Json.JsonProperty("disruptions", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.Dictionary<string, Disruption> Disruptions
        {
            get { return _disruptions; }
            set
            {
                if (_disruptions != value)
                {
                    _disruptions = value;
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

        public static DeparturesResponse FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<DeparturesResponse>(data);
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