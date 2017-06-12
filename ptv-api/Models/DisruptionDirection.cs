using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ptv_api.Models
{
    [GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public class DisruptionDirection : INotifyPropertyChanged
    {
        private int? _directionId;
        private string _directionName;
        private int? _routeDirectionId;
        private string _serviceTime;

        /// <summary>Route and direction of travel combination identifier</summary>
        [JsonProperty("route_direction_id", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public int? RouteDirectionId
        {
            get => _routeDirectionId;
            set
            {
                if (_routeDirectionId != value)
                {
                    _routeDirectionId = value;
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

        /// <summary>Name of direction of travel</summary>
        [JsonProperty("direction_name", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string DirectionName
        {
            get => _directionName;
            set
            {
                if (_directionName != value)
                {
                    _directionName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>
        ///     Time of service to which disruption applies, in 24 hour clock format (HH:MM:SS) AEDT/AEST; returns null if
        ///     disruption applies to multiple (or no) services
        /// </summary>
        [JsonProperty("service_time", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceTime
        {
            get => _serviceTime;
            set
            {
                if (_serviceTime != value)
                {
                    _serviceTime = value;
                    RaisePropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static DisruptionDirection FromJson(string data)
        {
            return JsonConvert.DeserializeObject<DisruptionDirection>(data);
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