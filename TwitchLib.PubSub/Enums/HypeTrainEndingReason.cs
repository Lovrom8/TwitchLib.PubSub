using System;
using System.Collections.Generic;
using System.Text;

namespace TwitchLib.PubSub.Enums
{
    /// <summary>
    /// Enum HypeTrainEndingReason
    /// </summary>
    public enum HypeTrainEndingReason
    {
        /// <summary>Hype train was completed</summary>
        Completed,
        /// <summary>Hype train ended before it was completed</summary>
        Expired
    }
}
