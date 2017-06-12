using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ptv_api.Models.Responses
{
    [GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public class DeparturesResponse : INotifyPropertyChanged
    {
        private ObservableCollection<Departure> _departures;
        private Dictionary<string, Direction> _directions;
        private Dictionary<string, Disruption> _disruptions;
        private Dictionary<string, Route> _routes;
        private Dictionary<string, Run> _runs;
        private Status _status;
        private Dictionary<string, ResultStop> _stops;

        /// <summary>Timetabled and real-time service departures</summary>
        [JsonProperty("departures", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public ObservableCollection<Departure> Departures
        {
            get => _departures;
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
        [JsonProperty("stops", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, ResultStop> Stops
        {
            get => _stops;
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
        [JsonProperty("routes", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Route> Routes
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

        /// <summary>Individual trips/services of a route</summary>
        [JsonProperty("runs", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Run> Runs
        {
            get => _runs;
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
        [JsonProperty("directions", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Direction> Directions
        {
            get => _directions;
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
        [JsonProperty("disruptions", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Disruption> Disruptions
        {
            get => _disruptions;
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
        [JsonProperty("status", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public Status Status
        {
            get => _status;
            set
            {
                if (_status != value)
                {
                    _status = value;
                    RaisePropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static DeparturesResponse FromJson(string data)
        {
            return JsonConvert.DeserializeObject<DeparturesResponse>(data);
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