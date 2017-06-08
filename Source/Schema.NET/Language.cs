namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Natural languages such as Spanish, Tamil, Hindi, English, etc...
    /// </summary>
    [DataContract]
    public class Language : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Language";
    }
}