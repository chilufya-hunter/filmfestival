//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Filmfestival
{
    using System;
    using System.Collections.Generic;
    
    public partial class film
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public film()
        {
            this.actor_film_director = new HashSet<actor_film_director>();
            this.film_nomination = new HashSet<film_nomination>();
        }
    
        public int id_film { get; set; }
        public string title { get; set; }
        public decimal rating { get; set; }
        public int year { get; set; }
        public int duration { get; set; }
        public string country { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<actor_film_director> actor_film_director { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<film_nomination> film_nomination { get; set; }
    }
}
