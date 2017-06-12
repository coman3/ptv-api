namespace PtvApi
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public partial class StopAccessibilityWheelchair : System.ComponentModel.INotifyPropertyChanged
    {
        private bool? _accessibleRamp;
        private bool? _accessibleParking;
        private bool? _accessiblePhone;
        private bool? _accessibleToilet;

        /// <summary>Indicates if there is a ramp at the stop that complies with the Disability Standards for Accessible Public Transport under the Disability Discrimination Act (1992)</summary>
        [Newtonsoft.Json.JsonProperty("accessible_ramp", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? AccessibleRamp
        {
            get { return _accessibleRamp; }
            set
            {
                if (_accessibleRamp != value)
                {
                    _accessibleRamp = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates if there is at least one accessible parking spot at the stop that complies with the Disability Standards for Accessible Public Transport under the Disability Discrimination Act (1992)</summary>
        [Newtonsoft.Json.JsonProperty("accessible_parking", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? AccessibleParking
        {
            get { return _accessibleParking; }
            set
            {
                if (_accessibleParking != value)
                {
                    _accessibleParking = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates if there is an accessible public telephone at the stop that complies with the Disability Standards for Accessible Public Transport under the Disability Discrimination Act (1992)</summary>
        [Newtonsoft.Json.JsonProperty("accessible_phone", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? AccessiblePhone
        {
            get { return _accessiblePhone; }
            set
            {
                if (_accessiblePhone != value)
                {
                    _accessiblePhone = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates if there is an accessible public toilet at the stop that complies with the Disability Standards for Accessible Public Transport under the Disability Discrimination Act (1992)</summary>
        [Newtonsoft.Json.JsonProperty("accessible_toilet", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? AccessibleToilet
        {
            get { return _accessibleToilet; }
            set
            {
                if (_accessibleToilet != value)
                {
                    _accessibleToilet = value;
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