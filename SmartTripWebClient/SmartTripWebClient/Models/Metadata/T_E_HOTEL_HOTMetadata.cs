using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SmartTripWebClient.Models.Metadata
{
    public class T_E_HOTEL_HOTMetadata
    {
        // SURCHARGE DE LA CLASSE MODEL 

        public decimal HOT_ID { get; set; }
        public decimal HTR_ID { get; set; }
        public decimal PRX_ID { get; set; }
        [Required]
        [DisplayName("Nom d'Hotel")]
        public string HOT_NOM { get; set; }
        [DisplayName("Etoiles")]
        [Required]
        public decimal CAT_NBETOILES { get; set; }
        [Required]
        [DisplayName("Description")]
        public string HOT_DESCRIPTION { get; set; }
        [DisplayName("Adresse ligne 1")]
        [Required]
        public string HOT_ADRLIGNE1 { get; set; }
        [DisplayName("Adresse ligne 2")]
        public string HOT_ADRLIGNE2 { get; set; }
        [DisplayName("Code Postale")]
        [Required]
        public string HOT_CP { get; set; }
        [DisplayName("Ville")]
        [Required]
        public string HOT_VILLE { get; set; }
        [DisplayName("Etat")]
        public string HOT_ETAT { get; set; }
        [DisplayName("Pays")]
        [Required]
        public decimal PAY_ID { get; set; }
        [System.Web.Mvc.HiddenInput(DisplayValue = false)]
        public float HOT_LATITUDE { get; set; }
        [System.Web.Mvc.HiddenInput(DisplayValue = false)]
        public float HOT_LONGITUDE { get; set; }
        [DisplayName("Indicatif")]
        [Required]
        public decimal IND_INDICATIF { get; set; }
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Telephone non valide: Verifiez le format du numéro")]

        [DisplayName("Telephone")]
        [Required]
        public string HOT_TEL { get; set; }
        [Required]
        [StringLength(1000, MinimumLength = 5, ErrorMessage = "Email non valide: Verifiez la taille du mail")]
        [EmailAddress(ErrorMessage = "Email non valide: Verifiez le format du mail")]
        [DisplayName("E-Mail")]
         
        public string HOT_MEL { get; set; }
        [DisplayName("Site Web")]
        public string HOT_SITEWEB { get; set; }
        [DisplayName("Nombre de chambres")]
        public Nullable<decimal> HOT_NBCHAMBRES { get; set; }
    }
}