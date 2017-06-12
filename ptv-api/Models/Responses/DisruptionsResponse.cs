using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ptv_api.Models.Responses
{
    [GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public class DisruptionsResponse : INotifyPropertyChanged
    {
        private Disruptions _disruptions;
        private Status _status;

        /// <summary>Disruption information applicable to relevant routes or stops</summary>
        [JsonProperty("disruptions", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public Disruptions Disruptions
        {
            get => _disruptions;
            set
            {
                if (_disruptions != value)
                {
                    _disruptions = value;
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

        public static DisruptionsResponse FromJson(string data)
        {
            return JsonConvert.DeserializeObject<DisruptionsResponse>(data);
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