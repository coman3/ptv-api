using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace PtvApi
{
    [GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public class StopLocation : INotifyPropertyChanged
    {
        private StopGps _gps;

        /// <summary>GPS coordinates of the stop</summary>
        [JsonProperty("gps", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public StopGps Gps
        {
            get => _gps;
            set
            {
                if (_gps != value)
                {
                    _gps = value;
                    RaisePropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static StopLocation FromJson(string data)
        {
            return JsonConvert.DeserializeObject<StopLocation>(data);
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