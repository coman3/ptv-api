using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ptv_api
{
    [GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public class StopDetails : INotifyPropertyChanged
    {
        private int? _routeType;
        private string _stationDescription;
        private string _stationType;
        private StopAccessibility _stopAccessibility;
        private StopAmenityDetails _stopAmenities;
        private int? _stopId;
        private StopLocation _stopLocation;
        private string _stopName;

        /// <summary>
        ///     Type of metropolitan train station (i.e. "Premium", "Host" or "Unstaffed" station); returns null for V/Line
        ///     train
        /// </summary>
        [JsonProperty("station_type", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string StationType
        {
            get => _stationType;
            set
            {
                if (_stationType != value)
                {
                    _stationType = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The definition applicable to the station_type; returns null for V/Line train</summary>
        [JsonProperty("station_description", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string StationDescription
        {
            get => _stationDescription;
            set
            {
                if (_stationDescription != value)
                {
                    _stationDescription = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Transport mode identifier</summary>
        [JsonProperty("route_type", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public int? RouteTypes
        {
            get => _routeType;
            set
            {
                if (_routeType != value)
                {
                    _routeType = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Location details of the stop</summary>
        [JsonProperty("stop_location", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public StopLocation StopLocation
        {
            get => _stopLocation;
            set
            {
                if (_stopLocation != value)
                {
                    _stopLocation = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Amenity and facility details at the stop</summary>
        [JsonProperty("stop_amenities", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public StopAmenityDetails StopAmenities
        {
            get => _stopAmenities;
            set
            {
                if (_stopAmenities != value)
                {
                    _stopAmenities = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Facilities relating to the accessibility of the stop</summary>
        [JsonProperty("stop_accessibility", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public StopAccessibility StopAccessibility
        {
            get => _stopAccessibility;
            set
            {
                if (_stopAccessibility != value)
                {
                    _stopAccessibility = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Stop identifier</summary>
        [JsonProperty("stop_id", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public int? StopId
        {
            get => _stopId;
            set
            {
                if (_stopId != value)
                {
                    _stopId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Name of stop</summary>
        [JsonProperty("stop_name", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string StopName
        {
            get => _stopName;
            set
            {
                if (_stopName != value)
                {
                    _stopName = value;
                    RaisePropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static StopDetails FromJson(string data)
        {
            return JsonConvert.DeserializeObject<StopDetails>(data);
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