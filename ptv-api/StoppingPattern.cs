using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace PtvApi
{
    [GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public class StoppingPattern : INotifyPropertyChanged
    {
        private ObservableCollection<Departure> _departures;
        private ObservableCollection<Disruption> _disruptions;
        private Status _status;

        /// <summary>Timetabled and real-time service departures</summary>
        [JsonProperty("departures", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public ObservableCollection<Departure> Departures
        {
            get => _departures;
            set
            {
                if (_departures != value)
                {
                    _departures = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Disruption information applicable to relevant routes or stops</summary>
        [JsonProperty("disruptions", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public ObservableCollection<Disruption> Disruptions
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

        public static StoppingPattern FromJson(string data)
        {
            return JsonConvert.DeserializeObject<StoppingPattern>(data);
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