using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace TwitchLib.PubSub.Enums
{
    /// <summary>
    /// Enum HypeTrainEndingReason
    /// </summary>
    public enum HypeTrainEndingReason
    {
        /// <summary>Hype train was completed</summary>
        [EnumMember(Value = "COMPLETED")] 
        Completed,
        /// <summary>Hype train ended before it was completed</summary>
        [EnumMember(Value = "EXPIRED")]
        Expired
    }
}
