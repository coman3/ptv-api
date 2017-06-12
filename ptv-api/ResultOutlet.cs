using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace PtvApi
{
    [GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public class ResultOutlet : INotifyPropertyChanged
    {
        private string _outletBusiness;
        private double? _outletDistance;
        private double? _outletLatitude;
        private double? _outletLongitude;
        private string _outletName;
        private string _outletSuburb;

        /// <summary>Distance of outlet from input location (in metres); returns 0 if no location is input</summary>
        [JsonProperty("outlet_distance", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public double? OutletDistance
        {
            get => _outletDistance;
            set
            {
                if (_outletDistance != value)
                {
                    _outletDistance = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The location name of the outlet</summary>
        [JsonProperty("outlet_name", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string OutletName
        {
            get => _outletName;
            set
            {
                if (_outletName != value)
                {
                    _outletName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The business name of the outlet</summary>
        [JsonProperty("outlet_business", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string OutletBusiness
        {
            get => _outletBusiness;
            set
            {
                if (_outletBusiness != value)
                {
                    _outletBusiness = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Geographic coordinate of latitude at outlet</summary>
        [JsonProperty("outlet_latitude", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public double? OutletLatitude
        {
            get => _outletLatitude;
            set
            {
                if (_outletLatitude != value)
                {
                    _outletLatitude = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Geographic coordinate of longitude at outlet</summary>
        [JsonProperty("outlet_longitude", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public double? OutletLongitude
        {
            get => _outletLongitude;
            set
            {
                if (_outletLongitude != value)
                {
                    _outletLongitude = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The suburb the outlet is in</summary>
        [JsonProperty("outlet_suburb", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string OutletSuburb
        {
            get => _outletSuburb;
            set
            {
                if (_outletSuburb != value)
                {
                    _outletSuburb = value;
                    RaisePropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static ResultOutlet FromJson(string data)
        {
            return JsonConvert.DeserializeObject<ResultOutlet>(data);
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