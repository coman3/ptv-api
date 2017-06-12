using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ptv_api.Models
{
    [GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public class StopGeosearch : INotifyPropertyChanged
    {
        private int? _routeType;
        private double? _stopDistance;
        private int? _stopId;
        private double? _stopLatitude;
        private double? _stopLongitude;
        private string _stopName;

        /// <summary>Distance of stop from input location (in metres); returns 0 if no location is input</summary>
        [JsonProperty("stop_distance", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public double? StopDistance
        {
            get => _stopDistance;
            set
            {
                if (_stopDistance != value)
                {
                    _stopDistance = value;
                    RaisePropertyChanged();
                }
            }
        }

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

        public static StopGeosearch FromJson(string data)
        {
            return JsonConvert.DeserializeObject<StopGeosearch>(data);
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