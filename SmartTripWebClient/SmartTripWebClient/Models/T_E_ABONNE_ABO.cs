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

    public partial class T_E_ABONNE_ABO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_E_ABONNE_ABO()
        {
            
        }
    
        public decimal ABO_ID { get; set; }
        public string ABO_PSEUDO { get; set; }
        public string ABO_MOTPASSE { get; set; }
        public string ABO_MEL { get; set; }
        public string ABO_NOM { get; set; }
        public string ABO_PRENOM { get; set; }
        public string ABO_ADRLIGNE1 { get; set; }
        public string ABO_ADRLIGNE2 { get; set; }
        public string ABO_CP { get; set; }
        public string ABO_VILLE { get; set; }
        public string ABO_ETAT { get; set; }
        public decimal PAY_ID { get; set; }
        public float ABO_LATITUDE { get; set; }
        public float ABO_LONGITUDE { get; set; }
        public decimal IND_INDICATIF { get; set; }
        public string ABO_TEL { get; set; }
        public string ABO_AEROPORT { get; set; }
    
        public virtual T_R_INDICATIFTEL_IND T_R_INDICATIFTEL_IND { get; set; }
        public virtual T_R_PAYS_PAY T_R_PAYS_PAY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [XmlIgnore]
        public virtual ICollection<T_E_AVIS_AVI> T_E_AVIS_AVI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [XmlIgnore]
        public virtual ICollection<T_E_HOTEL_HOT> T_E_HOTEL_HOT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [XmlIgnore]
        public virtual ICollection<T_E_AVIS_AVI> T_E_AVIS_AVI1 { get; set; }
    }
}
