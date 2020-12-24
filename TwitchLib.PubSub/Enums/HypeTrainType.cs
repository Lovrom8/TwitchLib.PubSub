using System;
using System.Collections.Generic;
using System.Text;

namespace TwitchLib.PubSub.Enums
{
    /// <summary>
    /// Enum HypeTrainType
    /// </summary>
    public enum HypeTrainType
    {
        /// <summary>When a hype train starts</summary>
        Start, 
        /// <summary>When a hype train progresses</summary>
        Progression,
        /// <summary>When a hype train levels up</summary>
        LevelUp,
        /// <summary>When a hype train ends</summary>
        End
    }
}
