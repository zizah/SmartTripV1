//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmartTripV1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_R_PERIODEVISITE_PER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_R_PERIODEVISITE_PER()
        {
            this.T_E_AVIS_AVI = new HashSet<T_E_AVIS_AVI>();
        }
    
        public decimal PER_ID { get; set; }
        public decimal PER_MOIS { get; set; }
        public decimal PER_ANNEE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_E_AVIS_AVI> T_E_AVIS_AVI { get; set; }
    }
}
