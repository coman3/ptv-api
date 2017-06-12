using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace PtvApi
{
    /// <summary>Filter by status of disruption</summary>
    [GeneratedCode("NJsonSchema", "8.33.6323.36213")]
    public enum DisruptionStatus2
    {
        [EnumMember(Value = "current")] Current = 0,

        [EnumMember(Value = "planned")] Planned = 1
    }
}