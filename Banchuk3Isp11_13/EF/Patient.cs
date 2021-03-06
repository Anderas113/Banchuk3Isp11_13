//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Banchuk3Isp11_13.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Patient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patient()
        {
            this.MedCart = new HashSet<MedCart>();
            this.Order = new HashSet<Order>();
        }
    
        public int IdPatient { get; set; }
        public string Name { get; set; }
        public int height { get; set; }
        public int weight { get; set; }
        public int length { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public System.DateTime DateOfRegestrition { get; set; }
        public int IdClient { get; set; }
        public string GenderId { get; set; }
        public int IdKind { get; set; }
        public int IdBreed { get; set; }
    
        public virtual Breed Breed { get; set; }
        public virtual Client Client { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual KindOfAnimal KindOfAnimal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedCart> MedCart { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }
    }
}
