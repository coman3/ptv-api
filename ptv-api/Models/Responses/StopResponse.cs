using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ptv_api.Models.Responses
{
    
    public class StopResponse : INotifyPropertyChanged
    {
        private Status _status;
        private StopDetails _stop;

        /// <summary>A metropolitan or V/Line train station</summary>
        [JsonProperty("stop", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public StopDetails Stop
        {
            get => _stop;
            set
            {
                if (_stop != value)
                {
                    _stop = value;
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

        public static StopResponse FromJson(string data)
        {
            return JsonConvert.DeserializeObject<StopResponse>(data);
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