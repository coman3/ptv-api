namespace PtvApi
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public partial class StopLocation : System.ComponentModel.INotifyPropertyChanged
    {
        private StopGps _gps;

        /// <summary>GPS coordinates of the stop</summary>
        [Newtonsoft.Json.JsonProperty("gps", Required = Newtonsoft.Json.Required.Default,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public StopGps Gps
        {
            get { return _gps; }
            set
            {
                if (_gps != value)
                {
                    _gps = value;
                    RaisePropertyChanged();
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static StopLocation FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<StopLocation>(data);
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