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
    
    public partial class T_J_STYLEAVIS_STA
    {
        public decimal AVI_ID { get; set; }
        public decimal STY_ID { get; set; }
        public string STA_VALEUR { get; set; }
    
        public virtual T_E_AVIS_AVI T_E_AVIS_AVI { get; set; }
        public virtual T_R_STYLE_STY T_R_STYLE_STY { get; set; }
    }
}
