using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ptv_api.Models
{
    
    public class Disruption : INotifyPropertyChanged
    {
        private string _description;
        private long? _disruptionId;
        private string _disruptionStatus;
        private string _disruptionType;
        private DateTime? _fromDate;
        private DateTime? _lastUpdated;
        private DateTime? _publishedOn;
        private ObservableCollection<DisruptionRoute> _routes;
        private string _title;
        private DateTime? _toDate;
        private string _url;

        /// <summary>Disruption information identifier</summary>
        [JsonProperty("disruption_id", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public long? DisruptionId
        {
            get => _disruptionId;
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
        [JsonProperty("title", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Title
        {
            get => _title;
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
        [JsonProperty("url", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Url
        {
            get => _url;
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
        [JsonProperty("description", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Description
        {
            get => _description;
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
        [JsonProperty("disruption_status", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string DisruptionStatus
        {
            get => _disruptionStatus;
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
        [JsonProperty("disruption_type", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string DisruptionType
        {
            get => _disruptionType;
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
        [JsonProperty("published_on", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? PublishedOn
        {
            get => _publishedOn;
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
        [JsonProperty("last_updated", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastUpdated
        {
            get => _lastUpdated;
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
        [JsonProperty("from_date", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FromDate
        {
            get => _fromDate;
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
        [JsonProperty("to_date", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ToDate
        {
            get => _toDate;
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
        [JsonProperty("routes", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public ObservableCollection<DisruptionRoute> Routes
        {
            get => _routes;
            set
            {
                if (_routes != value)
                {
                    _routes = value;
                    RaisePropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static Disruption FromJson(string data)
        {
            return JsonConvert.DeserializeObject<Disruption>(data);
        }

        protected virtual void RaisePropertyChanged(
            [CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}