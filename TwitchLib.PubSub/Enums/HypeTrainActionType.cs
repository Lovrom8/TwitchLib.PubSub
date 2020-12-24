using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace TwitchLib.PubSub.Enums
{
    /// <summary>
    /// Enum HypeTrainActionType
    /// </summary>
    public enum HypeTrainActionType
    {
        /// <summary>A cheer</summary>
        [EnumMember(Value = "CHEER")]
        Cheer,
        /// <summary>
        /// Tier 1 sub
        /// original name: TIER_1_SUB
        /// </summary>
        [EnumMember(Value = "TIER_1_SUB")]
        Tier1,
        /// <summary>
        /// Tier 2 sub
        /// original name: TIER_2_SUB
        /// </summary>
        [EnumMember(Value = "TIER_2_SUB")]
        Tier2,
        /// <summary>
        /// Tier 3 sub
        /// original name: TIER_3_SUB
        /// </summary>
        [EnumMember(Value = "TIER_3_SUB")]
        Tier3,
        /// <summary>
        /// Tier 1 gifted sub
        /// original name: TIER_1_GIFTED_SUB
        /// </summary>
        [EnumMember(Value = "TIER_1_GIFTED_SUB")]
        Tier1GiftedSub,
        /// <summary>
        /// Tier 2 gifted sub
        /// original name: TIER_2_GIFTED_SUB
        /// </summary>
        [EnumMember(Value = "TIER_2_GIFTED_SUB")]
        Tier2GiftedSub,
        /// <summary>
        /// Tier 3 gifted sub
        /// original name: TIER_3_GIFTED_SUB
        /// </summary>
        [EnumMember(Value = "TIER_3_GIFTED_SUB")]
        Tier3GiftedSub
    }
}
