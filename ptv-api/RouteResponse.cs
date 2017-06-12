using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace PtvApi
{
    [GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public class RouteResponse : INotifyPropertyChanged
    {
        private Route _route;
        private Status _status;

        /// <summary>Train lines, tram routes, bus routes, regional coach routes, Night Bus routes</summary>
        [JsonProperty("route", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public Route Route
        {
            get => _route;
            set
            {
                if (_route != value)
                {
                    _route = value;
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

        public static RouteResponse FromJson(string data)
        {
            return JsonConvert.DeserializeObject<RouteResponse>(data);
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