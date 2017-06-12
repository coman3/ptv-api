using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ptv_api
{
    [GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public class RunsResponse : INotifyPropertyChanged
    {
        private ObservableCollection<Run> _runs;
        private Status _status;

        /// <summary>Individual trips/services of a route</summary>
        [JsonProperty("runs", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public ObservableCollection<Run> Runs
        {
            get => _runs;
            set
            {
                if (_runs != value)
                {
                    _runs = value;
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

        public static RunsResponse FromJson(string data)
        {
            return JsonConvert.DeserializeObject<RunsResponse>(data);
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