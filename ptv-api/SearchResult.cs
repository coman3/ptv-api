using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace PtvApi
{
    [GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public class SearchResult : INotifyPropertyChanged
    {
        private ObservableCollection<ResultOutlet> _outlets;
        private ObservableCollection<ResultRoute> _routes;
        private Status _status;
        private ObservableCollection<ResultStop> _stops;

        /// <summary>Train stations, tram stops, bus stops, regional coach stops or Night Bus stops</summary>
        [JsonProperty("stops", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public ObservableCollection<ResultStop> Stops
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

        /// <summary>Train lines, tram routes, bus routes, regional coach routes, Night Bus routes</summary>
        [JsonProperty("routes", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public ObservableCollection<ResultRoute> Routes
        {
            get => _routes;
            set
            {
                if (_routes != value)
                {
                    _routes = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>myki ticket outlets</summary>
        [JsonProperty("outlets", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public ObservableCollection<ResultOutlet> Outlets
        {
            get => _outlets;
            set
            {
                if (_outlets != value)
                {
                    _outlets = value;
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

        public static SearchResult FromJson(string data)
        {
            return JsonConvert.DeserializeObject<SearchResult>(data);
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