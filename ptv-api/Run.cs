namespace PtvApi
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public partial class Run : System.ComponentModel.INotifyPropertyChanged
    {
        private int? _runId;
        private int? _routeId;
        private int? _routeType;
        private int? _finalStopId;
        private string _destinationName;
        private string _status;

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

        /// <summary>Transport mode identifier</summary>
        [Newtonsoft.Json.JsonProperty("route_type", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? RouteTypes
        {
            get { return _routeType; }
            set
            {
                if (_routeType != value)
                {
                    _routeType = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>stop_id of final stop of run</summary>
        [Newtonsoft.Json.JsonProperty("final_stop_id", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? FinalStopId
        {
            get { return _finalStopId; }
            set
            {
                if (_finalStopId != value)
                {
                    _finalStopId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Name of destination of run</summary>
        [Newtonsoft.Json.JsonProperty("destination_name", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DestinationName
        {
            get { return _destinationName; }
            set
            {
                if (_destinationName != value)
                {
                    _destinationName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Status of metropolitan train run; returns "scheduled" for other modes</summary>
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Status
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

        public static Run FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Run>(data);
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