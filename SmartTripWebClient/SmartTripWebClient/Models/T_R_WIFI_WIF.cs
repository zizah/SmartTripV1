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
    
    public partial class T_R_WIFI_WIF
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_R_WIFI_WIF()
        {
            this.T_E_AVIS_AVI = new HashSet<T_E_AVIS_AVI>();
        }
    
        public decimal WIF_ID { get; set; }
        public string WIF_LIBELLE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_E_AVIS_AVI> T_E_AVIS_AVI { get; set; }
    }
}