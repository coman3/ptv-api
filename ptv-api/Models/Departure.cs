using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ptv_api.Models
{
    [GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public class Departure : INotifyPropertyChanged
    {
        private bool? _atPlatform;
        private int? _directionId;
        private ObservableCollection<int> _disruptionIds;
        private DateTime? _estimatedDepartureUtc;
        private string _flags;
        private string _platformNumber;
        private int? _routeId;
        private int? _runId;
        private DateTime? _scheduledDepartureUtc;
        private int? _stopId;

        /// <summary>Stop identifier</summary>
        [JsonProperty("stop_id", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public int? StopId
        {
            get => _stopId;
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
        [JsonProperty("route_id", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public int? RouteId
        {
            get => _routeId;
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
        [JsonProperty("run_id", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public int? RunId
        {
            get => _runId;
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

        /// <summary>Disruption information identifier(s)</summary>
        [JsonProperty("disruption_ids", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public ObservableCollection<int> DisruptionIds
        {
            get => _disruptionIds;
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
        [JsonProperty("scheduled_departure_utc", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ScheduledDepartureUtc
        {
            get => _scheduledDepartureUtc;
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
        [JsonProperty("estimated_departure_utc", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EstimatedDepartureUtc
        {
            get => _estimatedDepartureUtc;
            set
            {
                if (_estimatedDepartureUtc != value)
                {
                    _estimatedDepartureUtc = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>
        ///     Indicates if the metropolitan train service is at the platform at the time of query; returns false for other
        ///     modes
        /// </summary>
        [JsonProperty("at_platform", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? AtPlatform
        {
            get => _atPlatform;
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
        [JsonProperty("platform_number", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string PlatformNumber
        {
            get => _platformNumber;
            set
            {
                if (_platformNumber != value)
                {
                    _platformNumber = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>
        ///     Flag indicating special condition for run (e.g. RR Reservations Required, GC Guaranteed Connection, DOO Drop
        ///     Off Only, PUO Pick Up Only, MO Mondays only, TU Tuesdays only, WE Wednesdays only, TH Thursdays only, FR Fridays
        ///     only, SS School days only; ignore E flag)
        /// </summary>
        [JsonProperty("flags", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Flags
        {
            get => _flags;
            set
            {
                if (_flags != value)
                {
                    _flags = value;
                    RaisePropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static Departure FromJson(string data)
        {
            return JsonConvert.DeserializeObject<Departure>(data);
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