//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmartTripWebClient.Models
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    public partial class T_E_PHOTO_PHO
    {
        public decimal PHO_ID { get; set; }
        public Nullable<decimal> HOT_ID { get; set; }
        public Nullable<decimal> AVI_ID { get; set; }
        public string PHO_URL { get; set; }
        [XmlIgnore]
        public virtual T_E_AVIS_AVI T_E_AVIS_AVI { get; set; }
        [XmlIgnore]
        public virtual T_E_HOTEL_HOT T_E_HOTEL_HOT { get; set; }
    }
}
