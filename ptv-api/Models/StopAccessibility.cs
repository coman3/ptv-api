using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ptv_api.Models
{
    
    public class StopAccessibility : INotifyPropertyChanged
    {
        private bool? _escalator;
        private bool? _hearingLoop;
        private bool? _lifts;
        private bool? _lighting;
        private bool? _stairs;
        private bool? _tactileTiles;
        private StopAccessibilityWheelchair _wheelchair;

        /// <summary>Indicates if there is lighting at the stop</summary>
        [JsonProperty("lighting", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Lighting
        {
            get => _lighting;
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
        [JsonProperty("stairs", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Stairs
        {
            get => _stairs;
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
        [JsonProperty("escalator", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Escalator
        {
            get => _escalator;
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
        [JsonProperty("lifts", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Lifts
        {
            get => _lifts;
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
        [JsonProperty("hearing_loop", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? HearingLoop
        {
            get => _hearingLoop;
            set
            {
                if (_hearingLoop != value)
                {
                    _hearingLoop = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates if there are tactile tiles (also known as tactile ground surface indicators, or TGSIs) at the stop</summary>
        [JsonProperty("tactile_tiles", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? TactileTiles
        {
            get => _tactileTiles;
            set
            {
                if (_tactileTiles != value)
                {
                    _tactileTiles = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Facilities relating to the accessibility of the stop by wheelchair</summary>
        [JsonProperty("wheelchair", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public StopAccessibilityWheelchair Wheelchair
        {
            get => _wheelchair;
            set
            {
                if (_wheelchair != value)
                {
                    _wheelchair = value;
                    RaisePropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static StopAccessibility FromJson(string data)
        {
            return JsonConvert.DeserializeObject<StopAccessibility>(data);
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