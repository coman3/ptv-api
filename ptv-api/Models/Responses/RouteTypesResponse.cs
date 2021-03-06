using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ptv_api.Models.Responses
{
    
    public class RouteTypesResponse : INotifyPropertyChanged
    {
        private ObservableCollection<RouteType> _routeTypes;
        private Status _status;

        /// <summary>Transport mode identifiers</summary>
        [JsonProperty("route_types", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public ObservableCollection<RouteType> RouteTypess
        {
            get => _routeTypes;
            set
            {
                if (_routeTypes != value)
                {
                    _routeTypes = value;
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

        public static RouteTypesResponse FromJson(string data)
        {
            return JsonConvert.DeserializeObject<RouteTypesResponse>(data);
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