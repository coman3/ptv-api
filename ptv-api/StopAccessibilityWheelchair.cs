namespace PtvApi
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public partial class StopAccessibilityWheelchair : System.ComponentModel.INotifyPropertyChanged
    {
        private bool? _accessible_ramp;
        private bool? _accessible_parking;
        private bool? _accessible_phone;
        private bool? _accessible_toilet;

        /// <summary>Indicates if there is a ramp at the stop that complies with the Disability Standards for Accessible Public Transport under the Disability Discrimination Act (1992)</summary>
        [Newtonsoft.Json.JsonProperty("accessible_ramp", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Accessible_ramp
        {
            get { return _accessible_ramp; }
            set
            {
                if (_accessible_ramp != value)
                {
                    _accessible_ramp = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates if there is at least one accessible parking spot at the stop that complies with the Disability Standards for Accessible Public Transport under the Disability Discrimination Act (1992)</summary>
        [Newtonsoft.Json.JsonProperty("accessible_parking", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Accessible_parking
        {
            get { return _accessible_parking; }
            set
            {
                if (_accessible_parking != value)
                {
                    _accessible_parking = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates if there is an accessible public telephone at the stop that complies with the Disability Standards for Accessible Public Transport under the Disability Discrimination Act (1992)</summary>
        [Newtonsoft.Json.JsonProperty("accessible_phone", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Accessible_phone
        {
            get { return _accessible_phone; }
            set
            {
                if (_accessible_phone != value)
                {
                    _accessible_phone = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates if there is an accessible public toilet at the stop that complies with the Disability Standards for Accessible Public Transport under the Disability Discrimination Act (1992)</summary>
        [Newtonsoft.Json.JsonProperty("accessible_toilet", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Accessible_toilet
        {
            get { return _accessible_toilet; }
            set
            {
                if (_accessible_toilet != value)
                {
                    _accessible_toilet = value;
                    RaisePropertyChanged();
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static StopAccessibilityWheelchair FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<StopAccessibilityWheelchair>(data);
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