using System;
using System.Collections.Generic;
using System.Text;
using TwitchLib.PubSub.Enums;

namespace TwitchLib.PubSub.Events
{
    /// <inheritdoc />
    /// <summary>
    /// Class representing arguments of a hype train event.
    /// </summary>
    public class OnHypeTrainArgs : EventArgs
    {
        /// <summary>
        /// Property representing the type of hype train event
        /// </summary>
        public HypeTrainType Type;

        /// <summary>
        /// The sequence id
        /// </summary>
        public string ChannelId;

        /// <summary>
        /// Hype train id
        /// </summary>
        public string Id;


    }
}
