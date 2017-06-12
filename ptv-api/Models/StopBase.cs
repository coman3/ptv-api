using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ptv_api.Models
{
    [GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public class StopBase : INotifyPropertyChanged
    {
        private int? _stopId;
        private string _stopName;

        /// <summary>Stop identifier</summary>
        [JsonProperty("stop_id", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public int? StopId
        {
            get => _stopId;
            set
            {
                if (_stopId != value)
                {
                    _stopId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Name of stop</summary>
        [JsonProperty("stop_name", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string StopName
        {
            get => _stopName;
            set
            {
                if (_stopName != value)
                {
                    _stopName = value;
                    RaisePropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static StopBase FromJson(string data)
        {
            return JsonConvert.DeserializeObject<StopBase>(data);
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