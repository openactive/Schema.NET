namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A group of multiple reservations with common values for all sub-reservations.
    /// </summary>
    [DataContract]
    public class ReservationPackage : Reservation
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "ReservationPackage";

        /// <summary>
        /// The individual reservations included in the package. Typically a repeated property.
        /// </summary>
        [DataMember(Name = "subReservation")]
        public Reservation SubReservation { get; set; }
    }
}