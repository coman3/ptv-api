using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace PtvApi
{
    [GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public class StopsOnRouteResponse : INotifyPropertyChanged
    {
        private Status _status;
        private ObservableCollection<StopOnRoute> _stops;

        /// <summary>Train stations, tram stops, bus stops, regional coach stops or Night Bus stops</summary>
        [JsonProperty("stops", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public ObservableCollection<StopOnRoute> Stops
        {
            get => _stops;
            set
            {
                if (_stops != value)
                {
                    _stops = value;
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

        public static StopsOnRouteResponse FromJson(string data)
        {
            return JsonConvert.DeserializeObject<StopsOnRouteResponse>(data);
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