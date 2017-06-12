using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace ptv_api
{
    /// <summary>Filter by status of disruption</summary>
    [GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public enum DisruptionStatus
    {
        [EnumMember(Value = "current")] Current = 0,

        [EnumMember(Value = "planned")] Planned = 1
    }
}