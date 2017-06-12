using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ptv_api
{
    [GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public class RouteType : INotifyPropertyChanged
    {
        private int? _routeType;
        private string _routeTypeName;

        /// <summary>Name of transport mode</summary>
        [JsonProperty("route_type_name", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string RouteTypesName
        {
            get => _routeTypeName;
            set
            {
                if (_routeTypeName != value)
                {
                    _routeTypeName = value;
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

        public static RouteType FromJson(string data)
        {
            return JsonConvert.DeserializeObject<RouteType>(data);
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