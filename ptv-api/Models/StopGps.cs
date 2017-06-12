using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ptv_api.Models
{
    
    public class StopGps : INotifyPropertyChanged
    {
        private double? _latitude;
        private double? _longitude;

        /// <summary>Geographic coordinate of latitude at stop</summary>
        [JsonProperty("latitude", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public double? Latitude
        {
            get => _latitude;
            set
            {
                if (!Equals(_latitude, value))
                {
                    _latitude = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Geographic coordinate of longitude at stop</summary>
        [JsonProperty("longitude", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public double? Longitude
        {
            get => _longitude;
            set
            {
                if (!Equals(_longitude, value))
                {
                    _longitude = value;
                    RaisePropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static StopGps FromJson(string data)
        {
            return JsonConvert.DeserializeObject<StopGps>(data);
        }

        protected virtual void RaisePropertyChanged(
            [CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}