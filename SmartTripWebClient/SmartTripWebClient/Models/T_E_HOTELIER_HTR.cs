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

    public partial class T_E_HOTELIER_HTR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_E_HOTELIER_HTR()
        {
            this.T_E_HOTEL_HOT = new HashSet<T_E_HOTEL_HOT>();
        }
    
        public decimal HTR_ID { get; set; }
        public string HTR_MEL { get; set; }
        public string HTR_MOTPASSE { get; set; }
        public string HTR_NOM { get; set; }
        public string HTR_PRENOM { get; set; }
        public string HTR_ADRLIGNE1 { get; set; }
        public string HTR_ADRLIGNE2 { get; set; }
        public string HTR_CP { get; set; }
        public string HTR_VILLE { get; set; }
        public string HTR_ETAT { get; set; }
        public decimal PAY_ID { get; set; }

        [XmlIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_E_HOTEL_HOT> T_E_HOTEL_HOT { get; set; }
        public virtual T_R_PAYS_PAY T_R_PAYS_PAY { get; set; }
    }
}
