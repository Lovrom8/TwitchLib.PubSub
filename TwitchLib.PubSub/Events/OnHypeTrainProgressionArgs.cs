using System;
using System.Collections.Generic;
using System.Text;
using TwitchLib.PubSub.Enums;
using TwitchLib.PubSub.Models;

namespace TwitchLib.PubSub.Events
{
    /// <inheritdoc />
    /// <summary>
    /// Class representing arguments of hype train progression event.
    /// </summary>
    class OnHypeTrainProgressionArgs
    {
        /// <summary>
        /// Unknown value.
        /// </summary>
        public long SequenceId;

        /// <summary>
        /// Source type of the progression
        /// </summary>
        public HypeTrainSourceType SourceType;

        /// <summary>
        /// Specific action done to keep the train rolling
        /// </summary>
        public HypeTrainActionType ActionType;

        /// <summary>
        /// Amount of actions done. i.e 500 (five-hundred) bits or 1 (one) tier 3 gift sub
        /// </summary>
        public int Quantity;

        /// <summary>
        /// Progress of hype train
        /// </summary>
        public HypeTrainProgress Progress;

        /// <summary>
        /// ID of the user
        /// </summary>
        public int UserID;

        /// <summary>
        /// Username of the user
        /// </summary>
        public string Username;

        /// <summary>
        /// Display ame of the user
        /// </summary>
        public string UserDisplayName;

        /// <summary>
        /// Profile picture of the user contributing to the train.
        /// </summary>
        public string UserProfileUrl;
    }
}
