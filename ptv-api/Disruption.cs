namespace PtvApi
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public partial class Disruption : System.ComponentModel.INotifyPropertyChanged
    {
        private long? _disruptionId;
        private string _title;
        private string _url;
        private string _description;
        private string _disruptionStatus;
        private string _disruptionType;
        private System.DateTime? _publishedOn;
        private System.DateTime? _lastUpdated;
        private System.DateTime? _fromDate;
        private System.DateTime? _toDate;
        private System.Collections.ObjectModel.ObservableCollection<DisruptionRoute> _routes;

        /// <summary>Disruption information identifier</summary>
        [Newtonsoft.Json.JsonProperty("disruption_id", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? DisruptionId
        {
            get { return _disruptionId; }
            set
            {
                if (_disruptionId != value)
                {
                    _disruptionId = value;
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
        public string DisruptionStatus
        {
            get { return _disruptionStatus; }
            set
            {
                if (_disruptionStatus != value)
                {
                    _disruptionStatus = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Type of disruption</summary>
        [Newtonsoft.Json.JsonProperty("disruption_type", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DisruptionType
        {
            get { return _disruptionType; }
            set
            {
                if (_disruptionType != value)
                {
                    _disruptionType = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Date and time disruption information is published on PTV website, in ISO 8601 UTC format</summary>
        [Newtonsoft.Json.JsonProperty("published_on", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? PublishedOn
        {
            get { return _publishedOn; }
            set
            {
                if (_publishedOn != value)
                {
                    _publishedOn = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Date and time disruption information was last updated by PTV, in ISO 8601 UTC format</summary>
        [Newtonsoft.Json.JsonProperty("last_updated", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? LastUpdated
        {
            get { return _lastUpdated; }
            set
            {
                if (_lastUpdated != value)
                {
                    _lastUpdated = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Date and time at which disruption begins, in ISO 8601 UTC format</summary>
        [Newtonsoft.Json.JsonProperty("from_date", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? FromDate
        {
            get { return _fromDate; }
            set
            {
                if (_fromDate != value)
                {
                    _fromDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Date and time at which disruption ends, in ISO 8601 UTC format (returns null if unknown)</summary>
        [Newtonsoft.Json.JsonProperty("to_date", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? ToDate
        {
            get { return _toDate; }
            set
            {
                if (_toDate != value)
                {
                    _toDate = value;
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