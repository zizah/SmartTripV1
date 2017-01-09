using System;
using System.ComponentModel.DataAnnotations;

namespace SmartTripWebClient.Models.Metadata
{
    public class T_E_HOTEL_HOTMetadata
    {
        public decimal HOT_ID { get; set; }
        public decimal HTR_ID { get; set; }
        public decimal PRX_ID { get; set; }
        public string HOT_NOM { get; set; }
        public string HOT_DESCRIPTION { get; set; }
        public string HOT_ADRLIGNE1 { get; set; }
        public string HOT_ADRLIGNE2 { get; set; }
        public string HOT_CP { get; set; }
        public string HOT_VILLE { get; set; }
        public string HOT_ETAT { get; set; }
        public decimal PAY_ID { get; set; }
        public float HOT_LATITUDE { get; set; }
        public float HOT_LONGITUDE { get; set; }
        public decimal IND_INDICATIF { get; set; }
        public decimal CAT_NBETOILES { get; set; }
        public string HOT_TEL { get; set; }
        [Required]
        [StringLength(2)]
        public string HOT_MEL { get; set; }
        public string HOT_SITEWEB { get; set; }
        public Nullable<decimal> HOT_NBCHAMBRES { get; set; }
    }
}