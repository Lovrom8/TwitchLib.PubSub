using System;
using System.Collections.Generic;
using System.Text;
using TwitchLib.PubSub.Enums;

namespace TwitchLib.PubSub.Models
{
    public class BitsRewards
    {
        /// <summary>
        /// Reward to conductor of bits
        /// </summary>
        public List<HypeTrainReward> Current;

        /// <summary>
        /// Rewards to former bits conductor
        /// </summary>
        public List<HypeTrainReward> Former;
    }

    public class SubsRewards
    {
        /// <summary>
        /// Rewards to subscriptions conductor
        /// </summary>
        public List<HypeTrainReward> Current;
        /// <summary>
        /// Rewards to former subscriptions conductor
        /// </summary>
        public List<HypeTrainReward> Former;
    }

    public class HypeTrainConductorRewards
    {
        /// <summary>
        /// Hype train public callout emote ID
        /// </summary>
        public string Bits;

        /// <summary>
        /// Hype train public callout emote ID
        /// </summary>
        public string CalloutEmoteId;
    }

    public class HypeTrainKickoff
    {
        /// <summary>
        /// Period in nanoseconds that events must occur
        /// </summary>
        public long Duration;
        /// <summary>
        /// Minimum participation points needed to kickoff a hypetrain
        /// </summary>
        public long MinPoints;

        /// <summary>
        /// Number of events needed to kickoff hypetrain
        /// </summary>
        public long NumOfEvents;
    }

    public class HypeTrainParticipationConversionRates
    {
        public long BitsCheer;
        public long BitsExtensions;
        public long BitsPoll;

        public long SubsTier1GiftedSub;
        public long SubsTier1Sub;
        public long SubsTier2GiftedSub;
        public long SubsTier2Sub;
        public long SubsTier3GiftedSub;
        public long SubsTier3Sub;
    }

    public class HypeTrainNotificationThresholds
    {
        public long BitsCheer;
        public long BitsExtensions;
        public long BitsPoll;

        public long SubsTier1GiftedSub;
        public long SubsTier1Sub;
        public long SubsTier2GiftedSub;
        public long SubsTier2Sub;
        public long SubsTier3GiftedSub;
        public long SubsTier3Sub;
    }

    /// Configuration of hype train
    public class HypeTrainConfig
    {
        /// <summary>
        /// Hype train public callout emote ID
        /// </summary>
        public string CalloutEmoteId;

        /// <summary>
        /// Hype train public callout emote token
        /// </summary>
        public string CalloutEmoteToken;

        /// <summary>
        /// ID of the channel
        /// </summary>
        public string ChannelId;

        /// <summary>
        /// Rewards for the conductors of the train
        /// </summary>
        public HypeTrainConductorRewards ConductorRewards;

        /// <summary>
        /// Cooldown duration in nanoseconds
        /// </summary>
        public long CooldownDuration;

        /// <summary>
        /// Difficulty of the hype train
        /// </summary>
        public HypeTrainDifficulty Difficulty;

        /// <summary>
        /// Difficulty settings
        /// </summary>
        public Dictionary<HypeTrainDifficulty, List<HypeTrainLevel>> DifficultySettings;

        /// <summary>
        /// Unknown
        /// </summary>
        public bool IsWhitelisted;

        /// <summary>
        /// Support events that must occur within a duration of time to kick off a Hype Train.
        /// </summary>
        public HypeTrainKickoff Kickoff;

        /// <summary>
        /// Thresholds for notifications
        /// </summary>
        public HypeTrainNotificationThresholds NotificationThresholds;

        /// Conversion rates for participations
        public HypeTrainParticipationConversionRates ParticipationConversionRates;

        /// <summary>
        /// Duration in nanoseconds of each level
        /// </summary>
        public long LevelDuration;

        /// <summary>
        /// Reward end date - always returns null
        /// </summary>
        // public long RewardEndDate;

        /// <summary>
        /// Whether the train has conductor badges flag
        /// </summary>
        public bool HasConductorBadges;

        /// <summary>
        /// Theme color of channel
        /// None if use_theme_color is set to false
        /// </summary>
        public string ThemeColor;

        /// <summary>
        /// Primary color in hex
        /// </summary>
        public string PrimaryHexColor;

        /// <summary>
        /// Whether personalized settings are used or not
        /// </summary>
        public bool UsePersonalizedSettings;

        /// <summary>
        /// Whether theme color is used or not
        /// </summary>
        public bool UseThemeColor;

        /// <summary>
        /// Whether creator color is used or not
        /// </summary>
        public bool UseCreatorColor;
    }
}
