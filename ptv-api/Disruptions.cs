using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace PtvApi
{
    [GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public class Disruptions : INotifyPropertyChanged
    {
        private ObservableCollection<Disruption> _general;
        private ObservableCollection<Disruption> _metroBus;
        private ObservableCollection<Disruption> _metroTrain;
        private ObservableCollection<Disruption> _metroTram;
        private ObservableCollection<Disruption> _regionalBus;
        private ObservableCollection<Disruption> _regionalCoach;
        private ObservableCollection<Disruption> _regionalTrain;

        /// <summary>Subset of disruption information applicable to multiple route_types</summary>
        [JsonProperty("general", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public ObservableCollection<Disruption> General
        {
            get => _general;
            set
            {
                if (_general != value)
                {
                    _general = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Subset of disruption information applicable to metropolitan train</summary>
        [JsonProperty("metro_train", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public ObservableCollection<Disruption> MetroTrain
        {
            get => _metroTrain;
            set
            {
                if (_metroTrain != value)
                {
                    _metroTrain = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Subset of disruption information applicable to metropolitan tram</summary>
        [JsonProperty("metro_tram", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public ObservableCollection<Disruption> MetroTram
        {
            get => _metroTram;
            set
            {
                if (_metroTram != value)
                {
                    _metroTram = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Subset of disruption information applicable to metropolitan bus</summary>
        [JsonProperty("metro_bus", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public ObservableCollection<Disruption> MetroBus
        {
            get => _metroBus;
            set
            {
                if (_metroBus != value)
                {
                    _metroBus = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Subset of disruption information applicable to V/Line train</summary>
        [JsonProperty("regional_train", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public ObservableCollection<Disruption> RegionalTrain
        {
            get => _regionalTrain;
            set
            {
                if (_regionalTrain != value)
                {
                    _regionalTrain = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Subset of disruption information applicable to V/Line coach</summary>
        [JsonProperty("regional_coach", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public ObservableCollection<Disruption> RegionalCoach
        {
            get => _regionalCoach;
            set
            {
                if (_regionalCoach != value)
                {
                    _regionalCoach = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Subset of disruption information applicable to regional bus</summary>
        [JsonProperty("regional_bus", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public ObservableCollection<Disruption> RegionalBus
        {
            get => _regionalBus;
            set
            {
                if (_regionalBus != value)
                {
                    _regionalBus = value;
                    RaisePropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static Disruptions FromJson(string data)
        {
            return JsonConvert.DeserializeObject<Disruptions>(data);
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