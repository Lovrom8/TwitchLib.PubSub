using System;
using System.Collections.Generic;
using System.Text;

namespace TwitchLib.PubSub.Models
{
    // https://github.com/Emilgardis/twitch_api2/blob/655025c6a461104d98122918f54cf3b71bbfd9dc/src/pubsub/hype_train.rs#L479
    public class HypeTrainReward
    {
        /// <summary>
        /// Reward type - EMOTE/BADGE
        /// </summary>
        public string Type;

        /// <summary>
        /// Reward ID
        /// </summary>
        public string Id;

        /// <summary>
        /// Token for this emote
        /// </summary>
        public string Token;

        /// <summary>
        /// Group ID of the reward
        /// </summary>
        public string GroupId;

        /// <summary>
        /// Level this reward is from
        /// </summary>
        public int RewardLevel;

        /// <summary>
        /// Group ID of the reward
        /// </summary>
        public string SetId;

        /// <summary>
        /// ID of the badge - specific for BADGE reward
        /// </summary>
        public string BadgeID;

        /// <summary>
        /// Image URL of the badge - specific for BADGE reward
        /// </summary>
        public string ImageURL;
    }

    public class HypeTrainLevel
    {
        public int Goal;

        /// <summary>
        /// Integer in 1-5 range
        /// </summary>
        public int Value;

        /// <summary>
        /// Description of level rewards
        /// </summary>
        public List<HypeTrainReward> Rewards;
    }

    public class HypeTrainProgress
    {
        /// <summary>
        ///  Hype train goal
        /// </summary>
        public int Goal;

        /// <summary>
        /// Current hype train level
        /// </summary>
        public HypeTrainLevel Level;

        /// <summary>
        /// Seconds until the train ends
        /// </summary>
        public int RemainingSeconds;

        /// <summary>
        /// Current amassed participation points in this level
        /// </summary>
        public int Total;

        /// <summary>
        /// Current total amassed participation points in all levels
        /// </summary>
        public int Value;
    }
}
