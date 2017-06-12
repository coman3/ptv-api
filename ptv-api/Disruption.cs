namespace PtvApi
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public partial class Disruption : System.ComponentModel.INotifyPropertyChanged
    {
        private long? _disruption_id;
        private string _title;
        private string _url;
        private string _description;
        private string _disruption_status;
        private string _disruption_type;
        private System.DateTime? _published_on;
        private System.DateTime? _last_updated;
        private System.DateTime? _from_date;
        private System.DateTime? _to_date;
        private System.Collections.ObjectModel.ObservableCollection<DisruptionRoute> _routes;

        /// <summary>Disruption information identifier</summary>
        [Newtonsoft.Json.JsonProperty("disruption_id", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? Disruption_id
        {
            get { return _disruption_id; }
            set
            {
                if (_disruption_id != value)
                {
                    _disruption_id = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Headline title summarising disruption information</summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title
        {
            get { return _title; }
            set
            {
                if (_title != value)
                {
                    _title = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>URL of relevant article on PTV website</summary>
        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Url
        {
            get { return _url; }
            set
            {
                if (_url != value)
                {
                    _url = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Description of the disruption</summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    _description = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Status of the disruption (e.g. "Planned", "Current")</summary>
        [Newtonsoft.Json.JsonProperty("disruption_status", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Disruption_status
        {
            get { return _disruption_status; }
            set
            {
                if (_disruption_status != value)
                {
                    _disruption_status = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Type of disruption</summary>
        [Newtonsoft.Json.JsonProperty("disruption_type", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Disruption_type
        {
            get { return _disruption_type; }
            set
            {
                if (_disruption_type != value)
                {
                    _disruption_type = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Date and time disruption information is published on PTV website, in ISO 8601 UTC format</summary>
        [Newtonsoft.Json.JsonProperty("published_on", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? Published_on
        {
            get { return _published_on; }
            set
            {
                if (_published_on != value)
                {
                    _published_on = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Date and time disruption information was last updated by PTV, in ISO 8601 UTC format</summary>
        [Newtonsoft.Json.JsonProperty("last_updated", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? Last_updated
        {
            get { return _last_updated; }
            set
            {
                if (_last_updated != value)
                {
                    _last_updated = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Date and time at which disruption begins, in ISO 8601 UTC format</summary>
        [Newtonsoft.Json.JsonProperty("from_date", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? From_date
        {
            get { return _from_date; }
            set
            {
                if (_from_date != value)
                {
                    _from_date = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Date and time at which disruption ends, in ISO 8601 UTC format (returns null if unknown)</summary>
        [Newtonsoft.Json.JsonProperty("to_date", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? To_date
        {
            get { return _to_date; }
            set
            {
                if (_to_date != value)
                {
                    _to_date = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Route relevant to a disruption (if applicable)</summary>
        [Newtonsoft.Json.JsonProperty("routes", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<DisruptionRoute> Routes
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

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Disruption FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Disruption>(data);
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