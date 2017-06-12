using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ptv_api.Models.Responses
{
    
    public class DisruptionResponse : INotifyPropertyChanged
    {
        private Disruption _disruption;
        private Status _status;

        /// <summary>Disruption information applicable to relevant routes or stops</summary>
        [JsonProperty("disruption", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public Disruption Disruption
        {
            get => _disruption;
            set
            {
                if (_disruption != value)
                {
                    _disruption = value;
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

        public static DisruptionResponse FromJson(string data)
        {
            return JsonConvert.DeserializeObject<DisruptionResponse>(data);
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