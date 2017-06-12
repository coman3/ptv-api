using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ptv_api.Models
{
    
    public class StopAmenityDetails : INotifyPropertyChanged
    {
        private string _carParking;
        private bool? _cctv;
        private bool? _taxiRank;
        private bool? _toilet;

        /// <summary>Indicates if there is a public toilet at or near the stop</summary>
        [JsonProperty("toilet", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Toilet
        {
            get => _toilet;
            set
            {
                if (_toilet != value)
                {
                    _toilet = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates if there is a taxi rank at or near the stop</summary>
        [JsonProperty("taxi_rank", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? TaxiRank
        {
            get => _taxiRank;
            set
            {
                if (_taxiRank != value)
                {
                    _taxiRank = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The number of free car parking spots at the stop</summary>
        [JsonProperty("car_parking", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string CarParking
        {
            get => _carParking;
            set
            {
                if (_carParking != value)
                {
                    _carParking = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicates if there are CCTV (i.e. closed circuit television) cameras at the stop</summary>
        [JsonProperty("cctv", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? Cctv
        {
            get => _cctv;
            set
            {
                if (_cctv != value)
                {
                    _cctv = value;
                    RaisePropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static StopAmenityDetails FromJson(string data)
        {
            return JsonConvert.DeserializeObject<StopAmenityDetails>(data);
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