using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ptv_api
{
    [GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public class RunResponse : INotifyPropertyChanged
    {
        private Run _run;
        private Status _status;

        /// <summary>Individual trip/service of a route</summary>
        [JsonProperty("run", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public Run Run
        {
            get => _run;
            set
            {
                if (_run != value)
                {
                    _run = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>API Status / Metadata</summary>
        [JsonProperty("status", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public Status Status
        {
            get => _status;
            set
            {
                if (_status != value)
                {
                    _status = value;
                    RaisePropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static RunResponse FromJson(string data)
        {
            return JsonConvert.DeserializeObject<RunResponse>(data);
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