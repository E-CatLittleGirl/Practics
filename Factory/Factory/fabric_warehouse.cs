//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Factory
{
    using System;
    using System.Collections.Generic;
    
    public partial class fabric_warehouse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public fabric_warehouse()
        {
            this.cuttings = new HashSet<cutting>();
        }
    
        public int id { get; set; }
        public string code_fabric { get; set; }
        public double length { get; set; }
        public int count { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cutting> cuttings { get; set; }
        public virtual fabric fabric { get; set; }
    }
}