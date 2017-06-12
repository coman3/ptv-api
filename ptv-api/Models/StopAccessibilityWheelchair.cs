using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ptv_api.Models
{
    
    public class StopAccessibilityWheelchair : INotifyPropertyChanged
    {
        private bool? _accessibleParking;
        private bool? _accessiblePhone;
        private bool? _accessibleRamp;
        private bool? _accessibleToilet;

        /// <summary>
        ///     Indicates if there is a ramp at the stop that complies with the Disability Standards for Accessible Public
        ///     Transport under the Disability Discrimination Act (1992)
        /// </summary>
        [JsonProperty("accessible_ramp", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? AccessibleRamp
        {
            get => _accessibleRamp;
            set
            {
                if (_accessibleRamp != value)
                {
                    _accessibleRamp = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>
        ///     Indicates if there is at least one accessible parking spot at the stop that complies with the Disability
        ///     Standards for Accessible Public Transport under the Disability Discrimination Act (1992)
        /// </summary>
        [JsonProperty("accessible_parking", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? AccessibleParking
        {
            get => _accessibleParking;
            set
            {
                if (_accessibleParking != value)
                {
                    _accessibleParking = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>
        ///     Indicates if there is an accessible public telephone at the stop that complies with the Disability Standards
        ///     for Accessible Public Transport under the Disability Discrimination Act (1992)
        /// </summary>
        [JsonProperty("accessible_phone", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? AccessiblePhone
        {
            get => _accessiblePhone;
            set
            {
                if (_accessiblePhone != value)
                {
                    _accessiblePhone = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>
        ///     Indicates if there is an accessible public toilet at the stop that complies with the Disability Standards for
        ///     Accessible Public Transport under the Disability Discrimination Act (1992)
        /// </summary>
        [JsonProperty("accessible_toilet", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? AccessibleToilet
        {
            get => _accessibleToilet;
            set
            {
                if (_accessibleToilet != value)
                {
                    _accessibleToilet = value;
                    RaisePropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static StopAccessibilityWheelchair FromJson(string data)
        {
            return JsonConvert.DeserializeObject<StopAccessibilityWheelchair>(data);
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