namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The Game type represents things which are games. These are typically rule-governed recreational activities, e.g. role-playing games in which players assume the role of characters in a fictional setting.
    /// </summary>
    [DataContract]
    public partial class Game : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Game";

        /// <summary>
        /// A piece of data that represents a particular aspect of a fictional character (skill, power, character points, advantage, disadvantage).
        /// </summary>
        [DataMember(Name = "characterAttribute", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<Thing> CharacterAttribute { get; set; }

        /// <summary>
        /// An item is an object within the game world that can be collected by a player or, occasionally, a non-player character.
        /// </summary>
        [DataMember(Name = "gameItem", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<Thing> GameItem { get; set; }

        /// <summary>
        /// Real or fictional location of the game (or part of game).
        /// </summary>
        [DataMember(Name = "gameLocation", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Place, PostalAddress, Uri> GameLocation { get; set; }

        /// <summary>
        /// Indicate how many people can play this game (minimum, maximum, or range).
        /// </summary>
        [DataMember(Name = "numberOfPlayers", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<QuantitativeValue> NumberOfPlayers { get; set; }

        /// <summary>
        /// The task that a player-controlled character, or group of characters may complete in order to gain a reward.
        /// </summary>
        [DataMember(Name = "quest", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<Thing> Quest { get; set; }
    }
}
