namespace PtvApi
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public partial class ResultOutlet : System.ComponentModel.INotifyPropertyChanged
    {
        private double? _outlet_distance;
        private string _outlet_name;
        private string _outlet_business;
        private double? _outlet_latitude;
        private double? _outlet_longitude;
        private string _outlet_suburb;

        /// <summary>Distance of outlet from input location (in metres); returns 0 if no location is input</summary>
        [Newtonsoft.Json.JsonProperty("outlet_distance", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Outlet_distance
        {
            get { return _outlet_distance; }
            set
            {
                if (_outlet_distance != value)
                {
                    _outlet_distance = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The location name of the outlet</summary>
        [Newtonsoft.Json.JsonProperty("outlet_name", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Outlet_name
        {
            get { return _outlet_name; }
            set
            {
                if (_outlet_name != value)
                {
                    _outlet_name = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The business name of the outlet</summary>
        [Newtonsoft.Json.JsonProperty("outlet_business", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Outlet_business
        {
            get { return _outlet_business; }
            set
            {
                if (_outlet_business != value)
                {
                    _outlet_business = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Geographic coordinate of latitude at outlet</summary>
        [Newtonsoft.Json.JsonProperty("outlet_latitude", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Outlet_latitude
        {
            get { return _outlet_latitude; }
            set
            {
                if (_outlet_latitude != value)
                {
                    _outlet_latitude = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Geographic coordinate of longitude at outlet</summary>
        [Newtonsoft.Json.JsonProperty("outlet_longitude", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Outlet_longitude
        {
            get { return _outlet_longitude; }
            set
            {
                if (_outlet_longitude != value)
                {
                    _outlet_longitude = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The suburb the outlet is in</summary>
        [Newtonsoft.Json.JsonProperty("outlet_suburb", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Outlet_suburb
        {
            get { return _outlet_suburb; }
            set
            {
                if (_outlet_suburb != value)
                {
                    _outlet_suburb = value;
                    RaisePropertyChanged();
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static ResultOutlet FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResultOutlet>(data);
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