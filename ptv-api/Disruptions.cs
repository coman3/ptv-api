namespace PtvApi
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public partial class Disruptions : System.ComponentModel.INotifyPropertyChanged
    {
        private System.Collections.ObjectModel.ObservableCollection<Disruption> _general;
        private System.Collections.ObjectModel.ObservableCollection<Disruption> _metroTrain;
        private System.Collections.ObjectModel.ObservableCollection<Disruption> _metroTram;
        private System.Collections.ObjectModel.ObservableCollection<Disruption> _metroBus;
        private System.Collections.ObjectModel.ObservableCollection<Disruption> _regionalTrain;
        private System.Collections.ObjectModel.ObservableCollection<Disruption> _regionalCoach;
        private System.Collections.ObjectModel.ObservableCollection<Disruption> _regionalBus;

        /// <summary>Subset of disruption information applicable to multiple route_types</summary>
        [Newtonsoft.Json.JsonProperty("general", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<Disruption> General
        {
            get { return _general; }
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
        [Newtonsoft.Json.JsonProperty("metro_train", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<Disruption> MetroTrain
        {
            get { return _metroTrain; }
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
        [Newtonsoft.Json.JsonProperty("metro_tram", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<Disruption> MetroTram
        {
            get { return _metroTram; }
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
        [Newtonsoft.Json.JsonProperty("metro_bus", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<Disruption> MetroBus
        {
            get { return _metroBus; }
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
        [Newtonsoft.Json.JsonProperty("regional_train", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<Disruption> RegionalTrain
        {
            get { return _regionalTrain; }
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
        [Newtonsoft.Json.JsonProperty("regional_coach", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<Disruption> RegionalCoach
        {
            get { return _regionalCoach; }
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
        [Newtonsoft.Json.JsonProperty("regional_bus", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<Disruption> RegionalBus
        {
            get { return _regionalBus; }
            set
            {
                if (_regionalBus != value)
                {
                    _regionalBus = value;
                    RaisePropertyChanged();
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Disruptions FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Disruptions>(data);
        }

        protected virtual void RaisePropertyChanged(
            [System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    }
}