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
    
    public partial class Doctor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Doctor()
        {
            this.Order = new HashSet<Order>();
            this.Schedule = new HashSet<Schedule>();
        }
    
        public int IdDoctor { get; set; }
        public string DoctorNane { get; set; }
        public string LastName { get; set; }
        public string Patronomyc { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string GenderId { get; set; }
        public int IdSpecality { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public System.DateTime DateOfBeginWork { get; set; }
        public decimal Salary { get; set; }
    
        public virtual Gender Gender { get; set; }
        public virtual Specality Specality { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Schedule> Schedule { get; set; }
    }
}
