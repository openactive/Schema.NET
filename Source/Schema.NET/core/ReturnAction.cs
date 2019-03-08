namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of returning to the origin that which was previously received (concrete objects) or taken (ownership).
    /// </summary>
    [DataContract]
    public partial class ReturnAction : TransferAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ReturnAction";

        /// <summary>
        /// A sub property of participant. The participant who is at the receiving end of the action.
        /// </summary>
        [DataMember(Name = "recipient", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Audience, ContactPoint, Organization, Person> Recipient { get; set; }
    }
}
