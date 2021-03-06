namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A direction indicating a single action to do in the instructions for how to achieve a result.
    /// </summary>
    [DataContract]
    public partial class HowToDirection : CreativeWorkAndListItem
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "HowToDirection";

        /// <summary>
        /// A media object representing the circumstances after performing this direction.
        /// </summary>
        [DataMember(Name = "afterMedia", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MediaObject, Uri> AfterMedia { get; set; }

        /// <summary>
        /// A media object representing the circumstances before performing this direction.
        /// </summary>
        [DataMember(Name = "beforeMedia", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MediaObject, Uri> BeforeMedia { get; set; }

        /// <summary>
        /// A media object representing the circumstances while performing this direction.
        /// </summary>
        [DataMember(Name = "duringMedia", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MediaObject, Uri> DuringMedia { get; set; }

        /// <summary>
        /// The length of time it takes to perform instructions or a direction (not including time to prepare the supplies), in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "performTime", Order = 309)]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesConverter))]
        public OneOrMany<TimeSpan?> PerformTime { get; set; }

        /// <summary>
        /// The length of time it takes to prepare the items to be used in instructions or a direction, in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "prepTime", Order = 310)]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesConverter))]
        public OneOrMany<TimeSpan?> PrepTime { get; set; }

        /// <summary>
        /// A sub-property of instrument. A supply consumed when performing instructions or a direction.
        /// </summary>
        [DataMember(Name = "supply", Order = 311)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<HowToSupply, string> Supply { get; set; }

        /// <summary>
        /// A sub property of instrument. An object used (but not consumed) when performing instructions or a direction.
        /// </summary>
        [DataMember(Name = "tool", Order = 312)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<HowToTool, string> Tool { get; set; }

        /// <summary>
        /// The total time required to perform instructions or a direction (including time to prepare the supplies), in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "totalTime", Order = 313)]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesConverter))]
        public OneOrMany<TimeSpan?> TotalTime { get; set; }
    }
}
