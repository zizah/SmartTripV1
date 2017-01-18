using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace SmartTripWebClient.Models.Metadata
{
    public class T_E_ABONNE_ABOMetadata
    {
        public decimal ABO_ID { get; set; }
        [Required]
        [DisplayName("PSEUDO")]
        public string ABO_PSEUDO { get; set; }
        [Required]
        [DisplayName("MOT DE PASSE")]
        public string ABO_MOTPASSE { get; set; }

        [StringLength(1000, MinimumLength = 5, ErrorMessage = "Email non valide: Verifiez la taille du mail")]
        [EmailAddress(ErrorMessage = "Email non valide: Verifiez le format du mail")]
        [DisplayName("EMAIL")]
        [Required]
        public string ABO_MEL { get; set; }
        [DisplayName("NOM")]
        [Required]
        public string ABO_NOM { get; set; }
        [DisplayName("PRENOM")]
        [Required]
        public string ABO_PRENOM { get; set; }
        [DisplayName("ADRESSE 1")]
        [Required]
        public string ABO_ADRLIGNE1 { get; set; }
        [DisplayName("ADRESSE 2")]
        public string ABO_ADRLIGNE2 { get; set; }
        [DisplayName("CODE POSTALE")]
        [Required]
        public string ABO_CP { get; set; }
        [DisplayName("VILLE")]
        [Required]
        public string ABO_VILLE { get; set; }
        [DisplayName("ETAT")]
        public string ABO_ETAT { get; set; }
        [DisplayName("PAYS")]
        [Required]
        public decimal PAY_ID { get; set; }
        public decimal IND_INDICATIF { get; set; }
        [DisplayName("TEL")]
        [Required]
        public string ABO_TEL { get; set; }
        [DisplayName("AEROPORT")]
        public string ABO_AEROPORT { get; set; }

        [XmlIgnore]
        public virtual T_R_INDICATIFTEL_IND T_R_INDICATIFTEL_IND { get; set; }

        [XmlIgnore]
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