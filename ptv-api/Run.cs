namespace PtvApi
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public partial class Run : System.ComponentModel.INotifyPropertyChanged
    {
        private int? _run_id;
        private int? _route_id;
        private int? _route_type;
        private int? _final_stop_id;
        private string _destination_name;
        private string _status;

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

        /// <summary>stop_id of final stop of run</summary>
        [Newtonsoft.Json.JsonProperty("final_stop_id", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Final_stop_id
        {
            get { return _final_stop_id; }
            set
            {
                if (_final_stop_id != value)
                {
                    _final_stop_id = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Name of destination of run</summary>
        [Newtonsoft.Json.JsonProperty("destination_name", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Destination_name
        {
            get { return _destination_name; }
            set
            {
                if (_destination_name != value)
                {
                    _destination_name = value;
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