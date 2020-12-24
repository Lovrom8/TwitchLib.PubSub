using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace TwitchLib.PubSub.Enums
{
    /// <summary>
    /// Enum HypeTrainSourceType
    /// </summary>
    public enum HypeTrainSourceType
    {
        /// <summary>Bits were used to keep the train going</summary>
        [EnumMember(Value = "BITS")] 
        Bits,
        /// <summary>Subscriptions were used to keep the train going</summary>
        [EnumMember(Value = "SUBS")] 
        Subs
    }
}
