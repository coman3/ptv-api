using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ptv_api
{
    [GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public class DeparturesBroadParameters : INotifyPropertyChanged
    {
        private DateTime? _dateUtc;
        private int? _directionId;
        private ObservableCollection<ExpandableParameter> _expand;
        private bool? _gtfs;
        private bool? _includeCancelled;
        private int? _maxResults;
        private ObservableCollection<int> _platformNumbers;

        /// <summary>Filter by platform number at stop</summary>
        [JsonProperty("platform_numbers", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public ObservableCollection<int> PlatformNumbers
        {
            get => _platformNumbers;
            set
            {
                if (_platformNumbers != value)
                {
                    _platformNumbers = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>
        ///     Filter by identifier of direction of travel; values returned by Directions API -
        ///     /v3/directions/route/{route_id}
        /// </summary>
        [JsonProperty("direction_id", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public int? DirectionId
        {
            get => _directionId;
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
        [JsonProperty("date_utc", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DateUtc
        {
            get => _dateUtc;
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
        [JsonProperty("max_results", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxResults
        {
            get => _maxResults;
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
        [JsonProperty("gtfs", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Gtfs
        {
            get => _gtfs;
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
        [JsonProperty("include_cancelled", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeCancelled
        {
            get => _includeCancelled;
            set
            {
                if (_includeCancelled != value)
                {
                    _includeCancelled = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>
        ///     List objects to be returned in full (i.e. expanded) - options include: all, stop, route, run, direction,
        ///     disruption
        /// </summary>
        [JsonProperty("expand", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore,
            ItemConverterType = typeof(StringEnumConverter))]
        public ObservableCollection<ExpandableParameter> Expand
        {
            get => _expand;
            set
            {
                if (_expand != value)
                {
                    _expand = value;
                    RaisePropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static DeparturesBroadParameters FromJson(string data)
        {
            return JsonConvert.DeserializeObject<DeparturesBroadParameters>(data);
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