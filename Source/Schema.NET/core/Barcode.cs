namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// An image of a visual machine-readable code such as a barcode or QR code.
    /// </summary>
    [DataContract]
    public class Barcode : ImageObject
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Barcode";
    }
}