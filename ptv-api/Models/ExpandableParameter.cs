using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace ptv_api.Models
{
    [GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public enum ExpandableParameter
    {
        [EnumMember(Value = "All")] All = 0,

        [EnumMember(Value = "Stop")] Stop = 1,

        [EnumMember(Value = "Route")] Route = 2,

        [EnumMember(Value = "Run")] Run = 3,

        [EnumMember(Value = "Direction")] Direction = 4,

        [EnumMember(Value = "Disruption")] Disruption = 5
    }
}