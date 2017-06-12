namespace PtvApi
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public partial class StoppingPattern : System.ComponentModel.INotifyPropertyChanged
    {
        private System.Collections.ObjectModel.ObservableCollection<Departure> _departures;
        private System.Collections.ObjectModel.ObservableCollection<Disruption> _disruptions;
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

        /// <summary>Disruption information applicable to relevant routes or stops</summary>
        [Newtonsoft.Json.JsonProperty("disruptions", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<Disruption> Disruptions
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

        public static StoppingPattern FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<StoppingPattern>(data);
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