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
    
    public partial class T_R_FOURCHETTEPRIX_PRX
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_R_FOURCHETTEPRIX_PRX()
        {
            this.T_E_HOTEL_HOT = new HashSet<T_E_HOTEL_HOT>();
        }
    
        public decimal PRX_ID { get; set; }
        public string PRX_FOURCHETTE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_E_HOTEL_HOT> T_E_HOTEL_HOT { get; set; }
    }
}
