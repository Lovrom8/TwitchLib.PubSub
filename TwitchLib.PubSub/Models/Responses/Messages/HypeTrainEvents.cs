using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using TwitchLib.PubSub.Enums;
using TwitchLib.PubSub.Extensions;

namespace TwitchLib.PubSub.Models.Responses.Messages
{
    /// <summary>
    /// Predictions model constructor.
    /// Implements the <see cref="MessageData" />
    /// </summary>
    /// <seealso cref="MessageData" />
    /// <inheritdoc />
    public class HypeTrainEvents : MessageData
    {
        /// <summary>
        /// Hype train event type
        /// </summary>
        /// <value>Type</value>
        public HypeTrainType Type { get; protected set; }

        /// <summary>
        /// Server time issued by Twitch.
        /// </summary>
        public long EndedAt { get; protected set; }

        /// <summary>
        /// Reason why the train ended.
        /// </summary>
        public HypeTrainEndingReason EndingReason { get; protected set; }

        /// <summary>
        /// The channel ID the event came from
        /// </summary>
        public string ChannelId { get; protected set; }

        /// <summary>
        /// Hype train configuration
        /// </summary>
        public HypeTrainConfig Config { get; protected set; }

        /// <summary>
        /// Server time epoch in milliseconds when hype train was updated
        /// </summary>
        public long StartedAt { get; protected set; }

        /// <summary>
        /// Server time epoch in milliseconds when hype train ends
        /// </summary>
        public long ExpiresAt { get; protected set; }

        /// <summary>
        /// Server time epoch in milliseconds when hype train was updated
        /// </summary>
        public long UpdatedAt { get; protected set; }

        /// <summary>
        /// ID of the hype train
        /// </summary>
        public string Id { get; protected set; }

        /// <summary>
        /// Progress of hype train
        /// </summary>
        public HypeTrainProgress Progress { get; protected set; }

        /// <summary>
        /// Current participations in the train
        /// </summary>
        public HypeTrainParticipations Participations { get; protected set; }

        /// <summary>
        /// Action done to progress
        /// </summary>
        public HypeTrainActionType Action { get; protected set; }

        /// <summary>
        /// Server time epoch in milliseconds when hype train expires.
        /// </summary>
        public long TimeToExpire { get; protected set; }

        /// <summary>
        /// Unknown value.
        /// </summary>
        public long SequenceId { get; protected set; }

        /// <summary>
        /// Source type of the progression
        /// </summary>
        public HypeTrainSourceType SourceType { get; protected set; }

        /// <summary>
        /// Specific action done to keep the train rolling
        /// </summary>
        public HypeTrainActionType ActionType { get; protected set; }

        /// <summary>
        /// Amount of actions done. i.e 500 (five-hundred) bits or 1 (one) tier 3 gift sub
        /// </summary>
        public int Quantity { get; protected set; }

        /// <summary>
        /// ID of the user
        /// </summary>
        public string UserID { get; protected set; }

        /// <summary>
        /// Username of the user
        /// </summary>
        public string Username { get; protected set; }

        /// <summary>
        /// Display ame of the user
        /// </summary>
        public string UserDisplayName { get; protected set; }

        /// <summary>
        /// Profile picture of the user contributing to the train.
        /// </summary>
        public string UserProfileImageUrl { get; protected set; }

        /// <summary>
        /// HypeTrainEvents constructor.
        /// </summary>
        /// <param name="jsonStr"></param>
        public HypeTrainEvents(string jsonStr)
        {
            var json = JObject.Parse(jsonStr);
            switch (json.SelectToken("type").ToString())
            {
                case "hype-train-start":
                    Type = HypeTrainType.Start;
                    break;
                case "hype-train-progression":
                    Type = HypeTrainType.Progression;
                    break;
                case "hype-train-level-up":
                    Type = HypeTrainType.LevelUp;
                    break;
                case "hype-train-end":
                    Type = HypeTrainType.End;
                    break;
            }

            var dataJson = JObject.Parse(jsonStr).SelectToken("data");
            switch (Type)
            {
                case HypeTrainType.Start:
                    var configJson = JObject.Parse(jsonStr).SelectToken("data").SelectToken("config");
                    var kickoffJson = JObject.Parse(jsonStr).SelectToken("data").SelectToken("kickoff");
                    Id = "";

                    Config = new HypeTrainConfig
                    {
                        ChannelId = dataJson.SelectToken("channel_id").ToString(),
                        IsWhitelisted = Convert.ToBoolean(configJson.SelectToken("channel_id")),

                        Kickoff = new HypeTrainKickoff
                        {
                            NumOfEvents = Convert.ToInt64(kickoffJson.SelectToken("num_of_events")),
                            MinPoints = Convert.ToInt64(kickoffJson.SelectToken("min_points")),
                            Duration = Convert.ToInt64(kickoffJson.SelectToken("duration"))
                        },

                        CooldownDuration = Convert.ToInt64(configJson.SelectToken("cooldown_duration")),
                        LevelDuration = Convert.ToInt64(configJson.SelectToken("level_duration")),

                        Difficulty = JsonConvert.DeserializeObject<HypeTrainDifficulty>(configJson.SelectToken("difficulty").ToString()),
                        //RewardEndDate = "";

                        ParticipationConversionRates = new HypeTrainParticipationConversionRates
                        {
                            BitsCheer = Convert.ToInt64(configJson.SelectToken("BITS.CHEER")),
                            /* These two are apparently unused
                            
                            BitsExtensions = Convert.ToInt64(configJson.SelectToken("BITS.EXTENSION")),
                            BitsPoll = Convert.ToInt64(configJson.SelectToken("BITS.POLL")), 
                            
                            */

                            SubsTier1GiftedSub = Convert.ToInt64(configJson.SelectToken("SUBS.TIER_1_GIFTED_SUB")),
                            SubsTier1Sub = Convert.ToInt64(configJson.SelectToken("SUBS.TIER_1_GIFTED_SUB")),
                            SubsTier2GiftedSub = Convert.ToInt64(configJson.SelectToken("SUBS.TIER_2_GIFTED_SUB")),
                            SubsTier2Sub = Convert.ToInt64(configJson.SelectToken("SUBS.TIER_2_GIFTED_SUB")),
                            SubsTier3GiftedSub = Convert.ToInt64(configJson.SelectToken("SUBS.TIER_3_GIFTED_SUB")),
                            SubsTier3Sub = Convert.ToInt64(configJson.SelectToken("SUBS.TIER_3_GIFTED_SUB"))
                        },

                        NotificationThresholds = new HypeTrainNotificationThresholds
                        {
                            BitsCheer = Convert.ToInt64(configJson.SelectToken("BITS.CHEER")),
                            /* 
                            BitsExtensions = Convert.ToInt64(configJson.SelectToken("BITS.EXTENSION")),
                            BitsPoll = Convert.ToInt64(configJson.SelectToken("BITS.POLL")), 
                            
                            */

                            SubsTier1GiftedSub = Convert.ToInt64(configJson.SelectToken("SUBS.TIER_1_GIFTED_SUB")),
                            SubsTier1Sub = Convert.ToInt64(configJson.SelectToken("SUBS.TIER_1_GIFTED_SUB")),
                            SubsTier2GiftedSub = Convert.ToInt64(configJson.SelectToken("SUBS.TIER_2_GIFTED_SUB")),
                            SubsTier2Sub = Convert.ToInt64(configJson.SelectToken("SUBS.TIER_2_GIFTED_SUB")),
                            SubsTier3GiftedSub = Convert.ToInt64(configJson.SelectToken("SUBS.TIER_3_GIFTED_SUB")),
                            SubsTier3Sub = Convert.ToInt64(configJson.SelectToken("SUBS.TIER_3_GIFTED_SUB"))
                        },

                        DifficultySettings = new Dictionary<HypeTrainDifficulty, List<HypeTrainLevel>>(),

                        // TODO: finish Conductor Rewards (the HypeTrainConductorRewards class needs to be finished)
                        // ConductorRewards = 

                        CalloutEmoteId = configJson.SelectToken("callout_emote_id").ToString(),
                        CalloutEmoteToken = configJson.SelectToken("callout_emote_token").ToString(),
                        ThemeColor = configJson.SelectToken("theme_color").ToString(),
                        HasConductorBadges = Convert.ToBoolean("has_conductor_badges")
                    };

                    var difficultySettingsJson = configJson.SelectToken("difficulty_settings").SelectToken(configJson.SelectToken("difficulty").ToString());
                    foreach (JToken levelSettingsJson in difficultySettingsJson.Children())
                    {
                        var rewardsList = new List<HypeTrainReward>();

                        foreach (JToken rewardInnerJson in levelSettingsJson.SelectToken("rewards").Children())
                        {
                            var rewardType = rewardInnerJson.SelectToken("type").ToString();
                            var newReward = new HypeTrainReward()
                            {
                                Type = rewardType,
                                Id = rewardInnerJson.SelectToken("id").ToString(),
                                GroupId = rewardInnerJson.SelectToken("group_id").ToString(),
                                RewardLevel = Convert.ToInt32(rewardInnerJson.SelectToken("reward_level")),
                            };


                            if (rewardType == "BADGE")
                            {
                                newReward.BadgeID = rewardInnerJson.SelectToken("badge_id").ToString();
                                newReward.ImageURL = rewardInnerJson.SelectToken("image_url").ToString();
                            }
                            else
                            {
                                newReward.Token = rewardInnerJson.SelectToken("token").ToString();
                                newReward.SetId = rewardInnerJson.SelectToken("set_id").ToString();
                            }

                            rewardsList.Add(newReward);
                        }

                        Config.DifficultySettings[Config.Difficulty].Add(new HypeTrainLevel
                        {
                            Value = Convert.ToInt32(levelSettingsJson.SelectToken("value")),
                            Goal = Convert.ToInt32(levelSettingsJson.SelectToken("goal")),
                            Rewards = rewardsList
                        });
                    }

                    Participations = new HypeTrainParticipations()
                    {
                        BitsCheer = Convert.ToInt64(configJson.SelectToken("BITS.CHEER")),
                        /* 
                        BitsExtensions = Convert.ToInt64(configJson.SelectToken("BITS.EXTENSION")),
                        BitsPoll = Convert.ToInt64(configJson.SelectToken("BITS.POLL")), 

                        */

                        SubsTier1GiftedSub = Convert.ToInt64(configJson.SelectToken("SUBS.TIER_1_GIFTED_SUB")),
                        SubsTier1Sub = Convert.ToInt64(configJson.SelectToken("SUBS.TIER_1_GIFTED_SUB")),
                        SubsTier2GiftedSub = Convert.ToInt64(configJson.SelectToken("SUBS.TIER_2_GIFTED_SUB")),
                        SubsTier2Sub = Convert.ToInt64(configJson.SelectToken("SUBS.TIER_2_GIFTED_SUB")),
                        SubsTier3GiftedSub = Convert.ToInt64(configJson.SelectToken("SUBS.TIER_3_GIFTED_SUB")),
                        SubsTier3Sub = Convert.ToInt64(configJson.SelectToken("SUBS.TIER_3_GIFTED_SUB"))
                    };

                    var progressJson = dataJson.SelectToken("progress");
                    var levelJson = progressJson.SelectToken("level");
                    Progress = new HypeTrainProgress()
                    {
                        Value = Convert.ToInt32(progressJson.SelectToken("value")),
                        Goal = Convert.ToInt32(progressJson.SelectToken("goal")),
                        Total = Convert.ToInt32(progressJson.SelectToken("value")),
                        RemainingSeconds = Convert.ToInt32(progressJson.SelectToken("remaining_seconds")),

                        Level = new HypeTrainLevel()
                        {
                            Value = Convert.ToInt32(progressJson.SelectToken("value")),
                            Goal = Convert.ToInt32(progressJson.SelectToken("goal")),
                            Rewards = new List<HypeTrainReward>()
                        }
                    };

                    var levelRewards = new List<HypeTrainReward>();
                    foreach (JToken rewardJson in levelJson.SelectToken("rewards").Children())
                    {
                        var rewardType = rewardJson.SelectToken("type").ToString();
                        var newReward = new HypeTrainReward()
                        {
                            Type = rewardType,
                            Id = rewardJson.SelectToken("id").ToString(),
                            GroupId = rewardJson.SelectToken("group_id").ToString(),
                            RewardLevel = Convert.ToInt32(rewardJson.SelectToken("reward_level")),
                        };

                        if (rewardType == "BADGE")
                        {
                            newReward.BadgeID = rewardJson.SelectToken("badge_id").ToString();
                            newReward.ImageURL = rewardJson.SelectToken("image_url").ToString();
                        }
                        else
                        {
                            newReward.Token = rewardJson.SelectToken("token").ToString();
                            newReward.SetId = rewardJson.SelectToken("set_id").ToString();
                        }

                        levelRewards.Add(newReward);
                    }

                    Progress.Level.Rewards = levelRewards;
                    break;

                case HypeTrainType.Progression:
                    UserID = dataJson.SelectToken("user_id").ToString();
                    Username = dataJson.SelectToken("user_login").ToString();
                    UserDisplayName = dataJson.SelectToken("user_display_name").ToString();
                    UserProfileImageUrl = dataJson.SelectToken("user_profile_image_url").ToString();
                    Action = JsonConvert.DeserializeObject<HypeTrainActionType>(dataJson.SelectToken("action").ToString());
                    Quantity = Convert.ToInt32(dataJson.SelectToken("quantity").ToString());

                    var progressionProgressJson = dataJson.SelectToken("progress");
                    var progressionLevelJson = progressionProgressJson.SelectToken("level");
                    Progress = new HypeTrainProgress()
                    {
                        Value = Convert.ToInt32(progressionProgressJson.SelectToken("value")),
                        Goal = Convert.ToInt32(progressionProgressJson.SelectToken("goal")),
                        Total = Convert.ToInt32(progressionProgressJson.SelectToken("value")),
                        RemainingSeconds = Convert.ToInt32(progressionProgressJson.SelectToken("remaining_seconds")),

                        Level = new HypeTrainLevel()
                        {
                            Value = Convert.ToInt32(progressionProgressJson.SelectToken("value")),
                            Goal = Convert.ToInt32(progressionProgressJson.SelectToken("goal")),
                            Rewards = new List<HypeTrainReward>()
                        }
                    };

                    var levelProgressionRewards = new List<HypeTrainReward>();
                    foreach (JToken rewardJson in progressionLevelJson.SelectToken("rewards").Children())
                    {
                        var rewardType = rewardJson.SelectToken("type").ToString();
                        var newReward = new HypeTrainReward()
                        {
                            Type = rewardType,
                            Id = rewardJson.SelectToken("id").ToString(),
                            GroupId = rewardJson.SelectToken("group_id").ToString(),
                            RewardLevel = Convert.ToInt32(rewardJson.SelectToken("reward_level")),
                        };

                        if (rewardType == "BADGE")
                        {
                            newReward.BadgeID = rewardJson.SelectToken("badge_id").ToString();
                            newReward.ImageURL = rewardJson.SelectToken("image_url").ToString();
                        }
                        else
                        {
                            newReward.Token = rewardJson.SelectToken("token").ToString();
                            newReward.SetId = rewardJson.SelectToken("set_id").ToString();
                        }

                        levelProgressionRewards.Add(newReward);
                    }

                    Progress.Level.Rewards = levelProgressionRewards;
                    break;

                case HypeTrainType.LevelUp:
                    TimeToExpire = Convert.ToInt64(dataJson.SelectToken("time_to_expire"));

                    var levelUpProgressJson = dataJson.SelectToken("progress");
                    var levelUpJson = levelUpProgressJson.SelectToken("level");
                    Progress = new HypeTrainProgress()
                    {
                        Value = Convert.ToInt32(levelUpJson.SelectToken("value")),
                        Goal = Convert.ToInt32(levelUpJson.SelectToken("goal")),
                        Total = Convert.ToInt32(levelUpJson.SelectToken("value")),
                        RemainingSeconds = Convert.ToInt32(levelUpJson.SelectToken("remaining_seconds")),

                        Level = new HypeTrainLevel()
                        {
                            Value = Convert.ToInt32(levelUpJson.SelectToken("value")),
                            Goal = Convert.ToInt32(levelUpJson.SelectToken("goal")),
                            Rewards = new List<HypeTrainReward>()
                        }
                    };

                    var levelUpRewards = new List<HypeTrainReward>();
                    foreach (JToken rewardJson in levelUpJson.SelectToken("rewards").Children())
                    {
                        var rewardType = rewardJson.SelectToken("type").ToString();
                        var newReward = new HypeTrainReward()
                        {
                            Type = rewardType,
                            Id = rewardJson.SelectToken("id").ToString(),
                            GroupId = rewardJson.SelectToken("group_id").ToString(),
                            RewardLevel = Convert.ToInt32(rewardJson.SelectToken("reward_level")),
                        };

                        if (rewardType == "BADGE")
                        {
                            newReward.BadgeID = rewardJson.SelectToken("badge_id").ToString();
                            newReward.ImageURL = rewardJson.SelectToken("image_url").ToString();
                        }
                        else
                        {
                            newReward.Token = rewardJson.SelectToken("token").ToString();
                            newReward.SetId = rewardJson.SelectToken("set_id").ToString();
                        }

                        levelUpRewards.Add(newReward);
                    }

                    Progress.Level.Rewards = levelUpRewards;
                    break;

                case HypeTrainType.End:
                    EndedAt = Convert.ToInt64(dataJson.SelectToken("ended_at"));
                    EndingReason = JsonConvert.DeserializeObject<HypeTrainEndingReason>(dataJson.SelectToken("ending_reason").ToString());
                    break;
            }
        }
    }
}
