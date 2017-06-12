using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ptv_api.Models
{
    
    public class Status : INotifyPropertyChanged
    {
        private StatusHealth? _health;
        private string _version;

        /// <summary>API Version number</summary>
        [JsonProperty("version", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string Version
        {
            get => _version;
            set
            {
                if (_version != value)
                {
                    _version = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>API system health status (0=offline, 1=online)</summary>
        [JsonProperty("health", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public StatusHealth? Health
        {
            get => _health;
            set
            {
                if (_health != value)
                {
                    _health = value;
                    RaisePropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static Status FromJson(string data)
        {
            return JsonConvert.DeserializeObject<Status>(data);
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