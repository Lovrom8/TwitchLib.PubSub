using System;
using System.Collections.Generic;
using System.Text;
using TwitchLib.PubSub.Enums;

namespace TwitchLib.PubSub.Events
{
    /// <inheritdoc />
    /// <summary>
    /// HypeTrainEnd arguments class.
    /// </summary>
    public class OnHypeTrainEndArgs : EventArgs
    {
        /// <summary>
        /// Server time issued by Twitch.
        /// </summary>
        public string EndedAt;
        /// <summary>
        /// Reason why the train ended.
        /// </summary>
        public HypeTrainEndingReason EndingReason;
    }
}
