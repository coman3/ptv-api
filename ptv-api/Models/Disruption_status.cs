using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace ptv_api.Models
{
    /// <summary>Filter by status of disruption</summary>
    
    public enum DisruptionStatus
    {
        [EnumMember(Value = "current")] Current = 0,

        [EnumMember(Value = "planned")] Planned = 1
    }
}