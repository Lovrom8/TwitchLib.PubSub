using System;
using TwitchLib.PubSub.Models;

namespace TwitchLib.PubSub.Events
{
    /// <inheritdoc />
    /// <summary>
    /// Class representing arguments of on hype train start event.
    /// </summary>
    public class OnHypeTrainStartArgs : EventArgs
    {
        /// <summary>
        /// The channel ID the event came from
        /// </summary>
        public string ChannelId;

        /// <summary>
        /// Current conductors of this hype-train - not implemented in the API, just the empty field exists
        /// </summary>
        // public Conductor conductors: Conductors,

        /// <summary>
        /// Hype train configuration
        /// </summary>
        public HypeTrainConfig Config;

        /// <summary>
        /// Server time epoch in milliseconds when hype train was updated
        /// </summary>
        public long StartedAt;

        /// <summary>
        /// Server time epoch in milliseconds when hype train ends
        /// </summary>
        public long ExpiresAt;

        /// <summary>
        /// Server time epoch in milliseconds when hype train was updated
        /// </summary>
        public long UpdatedAt;

        /// <summary>
        /// ID of the hype train
        /// </summary>
        public string Id;

        /// <summary>
        /// Ending reason - maybe use the enum
        /// </summary>
        public string EndingReason;

        /// <summary>
        /// Progress of hype train
        /// </summary>
        public HypeTrainProgress Progress;
    }
}
