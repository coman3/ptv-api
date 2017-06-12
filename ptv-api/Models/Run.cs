using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ptv_api.Models
{
    
    public class Run : INotifyPropertyChanged
    {
        private string _destinationName;
        private int? _finalStopId;
        private int? _routeId;
        private int? _routeType;
        private int? _runId;
        private string _status;

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

        /// <summary>Transport mode identifier</summary>
        [JsonProperty("route_type", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public int? RouteTypes
        {
            get => _routeType;
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
        [JsonProperty("final_stop_id", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public int? FinalStopId
        {
            get => _finalStopId;
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
        [JsonProperty("destination_name", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationName
        {
            get => _destinationName;
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
        [JsonProperty("status", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Status
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

        public static Run FromJson(string data)
        {
            return JsonConvert.DeserializeObject<Run>(data);
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