using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace TwitchLib.PubSub.Enums
{
    /// <summary>
    /// Enum HypeTrainDifficulty
    /// </summary>
    public enum HypeTrainDifficulty
    {
        /// <summary>Hype train easy difficulty</summary>
        [EnumMember(Value = "EASY")] 
        Easy,
        /// <summary>Hype train medium difficulty</summary>
        [EnumMember(Value = "MEDIUM")] 
        Medium,
        /// <summary>Hype train hard difficulty</summary>
        [EnumMember(Value = "HARD")] 
        Hard,
        /// <summary>Hype train super hard difficulty</summary>
        [EnumMember(Value = "SUPER HARD")] 
        SuperHard,
        /// <summary>Hype train insane difficulty</summary>
        [EnumMember(Value = "INSANE")] 
        Insane
    }
}
