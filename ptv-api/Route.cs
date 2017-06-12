using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace PtvApi
{
    [GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public class Route : INotifyPropertyChanged
    {
        private int? _routeId;
        private string _routeName;
        private string _routeNumber;
        private int? _routeType;

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

        /// <summary>Name of route</summary>
        [JsonProperty("route_name", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string RouteName
        {
            get => _routeName;
            set
            {
                if (_routeName != value)
                {
                    _routeName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Route number presented to public (nb. not route_id)</summary>
        [JsonProperty("route_number", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string RouteNumber
        {
            get => _routeNumber;
            set
            {
                if (_routeNumber != value)
                {
                    _routeNumber = value;
                    RaisePropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static Route FromJson(string data)
        {
            return JsonConvert.DeserializeObject<Route>(data);
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