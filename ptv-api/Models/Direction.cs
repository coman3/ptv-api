using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ptv_api.Models
{
    
    public class Direction : INotifyPropertyChanged
    {
        private int? _directionId;
        private string _directionName;
        private int? _routeId;
        private int? _routeType;

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

        public event PropertyChangedEventHandler PropertyChanged;

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static Direction FromJson(string data)
        {
            return JsonConvert.DeserializeObject<Direction>(data);
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