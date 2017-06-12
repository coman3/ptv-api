namespace PtvApi
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public partial class Disruptions : System.ComponentModel.INotifyPropertyChanged
    {
        private System.Collections.ObjectModel.ObservableCollection<Disruption> _general;
        private System.Collections.ObjectModel.ObservableCollection<Disruption> _metro_train;
        private System.Collections.ObjectModel.ObservableCollection<Disruption> _metro_tram;
        private System.Collections.ObjectModel.ObservableCollection<Disruption> _metro_bus;
        private System.Collections.ObjectModel.ObservableCollection<Disruption> _regional_train;
        private System.Collections.ObjectModel.ObservableCollection<Disruption> _regional_coach;
        private System.Collections.ObjectModel.ObservableCollection<Disruption> _regional_bus;

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
        public System.Collections.ObjectModel.ObservableCollection<Disruption> Metro_train
        {
            get { return _metro_train; }
            set
            {
                if (_metro_train != value)
                {
                    _metro_train = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Subset of disruption information applicable to metropolitan tram</summary>
        [Newtonsoft.Json.JsonProperty("metro_tram", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<Disruption> Metro_tram
        {
            get { return _metro_tram; }
            set
            {
                if (_metro_tram != value)
                {
                    _metro_tram = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Subset of disruption information applicable to metropolitan bus</summary>
        [Newtonsoft.Json.JsonProperty("metro_bus", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<Disruption> Metro_bus
        {
            get { return _metro_bus; }
            set
            {
                if (_metro_bus != value)
                {
                    _metro_bus = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Subset of disruption information applicable to V/Line train</summary>
        [Newtonsoft.Json.JsonProperty("regional_train", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<Disruption> Regional_train
        {
            get { return _regional_train; }
            set
            {
                if (_regional_train != value)
                {
                    _regional_train = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Subset of disruption information applicable to V/Line coach</summary>
        [Newtonsoft.Json.JsonProperty("regional_coach", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<Disruption> Regional_coach
        {
            get { return _regional_coach; }
            set
            {
                if (_regional_coach != value)
                {
                    _regional_coach = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Subset of disruption information applicable to regional bus</summary>
        [Newtonsoft.Json.JsonProperty("regional_bus", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<Disruption> Regional_bus
        {
            get { return _regional_bus; }
            set
            {
                if (_regional_bus != value)
                {
                    _regional_bus = value;
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