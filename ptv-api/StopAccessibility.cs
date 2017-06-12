namespace PtvApi
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public partial class StopAccessibility : System.ComponentModel.INotifyPropertyChanged
    {
        private bool? _lighting;
        private bool? _stairs;
        private bool? _escalator;
        private bool? _lifts;
        private bool? _hearing_loop;
        private bool? _tactile_tiles;
        private StopAccessibilityWheelchair _wheelchair;

        /// <summary>Indicates if there is lighting at the stop</summary>
        [Newtonsoft.Json.JsonProperty("lighting", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Lighting
        {
            get { return _lighting; }
            set
            {
                if (_lighting != value)
                {
                    _lighting = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates if there are stairs at the stop</summary>
        [Newtonsoft.Json.JsonProperty("stairs", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Stairs
        {
            get { return _stairs; }
            set
            {
                if (_stairs != value)
                {
                    _stairs = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates if there is an escalator at the stop</summary>
        [Newtonsoft.Json.JsonProperty("escalator", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Escalator
        {
            get { return _escalator; }
            set
            {
                if (_escalator != value)
                {
                    _escalator = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates if there is an elevator at the stop</summary>
        [Newtonsoft.Json.JsonProperty("lifts", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Lifts
        {
            get { return _lifts; }
            set
            {
                if (_lifts != value)
                {
                    _lifts = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates if there is a hearing loop facility at the stop</summary>
        [Newtonsoft.Json.JsonProperty("hearing_loop", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Hearing_loop
        {
            get { return _hearing_loop; }
            set
            {
                if (_hearing_loop != value)
                {
                    _hearing_loop = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates if there are tactile tiles (also known as tactile ground surface indicators, or TGSIs) at the stop</summary>
        [Newtonsoft.Json.JsonProperty("tactile_tiles", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Tactile_tiles
        {
            get { return _tactile_tiles; }
            set
            {
                if (_tactile_tiles != value)
                {
                    _tactile_tiles = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Facilities relating to the accessibility of the stop by wheelchair</summary>
        [Newtonsoft.Json.JsonProperty("wheelchair", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public StopAccessibilityWheelchair Wheelchair
        {
            get { return _wheelchair; }
            set
            {
                if (_wheelchair != value)
                {
                    _wheelchair = value;
                    RaisePropertyChanged();
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static StopAccessibility FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<StopAccessibility>(data);
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