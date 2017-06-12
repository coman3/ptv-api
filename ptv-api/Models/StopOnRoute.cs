using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ptv_api.Models
{
    [GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public class StopOnRoute : INotifyPropertyChanged
    {
        private int? _routeType;
        private int? _stopId;
        private double? _stopLatitude;
        private double? _stopLongitude;
        private string _stopName;

        /// <summary>Name of stop</summary>
        [JsonProperty("stop_name", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string StopName
        {
            get => _stopName;
            set
            {
                if (_stopName != value)
                {
                    _stopName = value;
                    RaisePropertyChanged();
                }
            }
        }

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

        /// <summary>Geographic coordinate of latitude at stop</summary>
        [JsonProperty("stop_latitude", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public double? StopLatitude
        {
            get => _stopLatitude;
            set
            {
                if (_stopLatitude != value)
                {
                    _stopLatitude = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Geographic coordinate of longitude at stop</summary>
        [JsonProperty("stop_longitude", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public double? StopLongitude
        {
            get => _stopLongitude;
            set
            {
                if (_stopLongitude != value)
                {
                    _stopLongitude = value;
                    RaisePropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static StopOnRoute FromJson(string data)
        {
            return JsonConvert.DeserializeObject<StopOnRoute>(data);
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