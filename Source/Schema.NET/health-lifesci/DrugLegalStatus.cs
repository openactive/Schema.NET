namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The legal availability status of a medical drug.
    /// </summary>
    [DataContract]
    public partial class DrugLegalStatus : MedicalIntangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DrugLegalStatus";

        /// <summary>
        /// The location in which the status applies.
        /// </summary>
        [DataMember(Name = "applicableLocation", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<AdministrativeArea> ApplicableLocation { get; set; }
    }
}
