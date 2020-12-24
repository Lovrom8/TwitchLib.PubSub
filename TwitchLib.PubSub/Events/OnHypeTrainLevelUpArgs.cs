using System;
using System.Collections.Generic;
using System.Text;
using TwitchLib.PubSub.Models;

namespace TwitchLib.PubSub.Events
{
    /// <inheritdoc />
    /// <summary>
    /// Class representing arguments of hype train level up event.
    /// </summary>
    public class OnHypeTrainLevelUpArgs : EventArgs
    {
        /// <summary>
        /// Server time epoch in milliseconds when hype train expires.
        /// </summary>
        public long TimeToExpire;
        /// <summary>
        /// Progress of hype train
        /// </summary>
        public HypeTrainProgress Progress;
    }
}
