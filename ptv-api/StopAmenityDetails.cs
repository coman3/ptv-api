namespace PtvApi
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public partial class StopAmenityDetails : System.ComponentModel.INotifyPropertyChanged
    {
        private bool? _toilet;
        private bool? _taxiRank;
        private string _carParking;
        private bool? _cctv;

        /// <summary>Indicates if there is a public toilet at or near the stop</summary>
        [Newtonsoft.Json.JsonProperty("toilet", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Toilet
        {
            get { return _toilet; }
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
        [Newtonsoft.Json.JsonProperty("taxi_rank", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? TaxiRank
        {
            get { return _taxiRank; }
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
        [Newtonsoft.Json.JsonProperty("car_parking", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CarParking
        {
            get { return _carParking; }
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
        [Newtonsoft.Json.JsonProperty("cctv", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Cctv
        {
            get { return _cctv; }
            set
            {
                if (_cctv != value)
                {
                    _cctv = value;
                    RaisePropertyChanged();
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static StopAmenityDetails FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<StopAmenityDetails>(data);
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