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
    
    public partial class fabric
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public fabric()
        {
            this.fabric_color = new HashSet<fabric_color>();
            this.fabric_drawing = new HashSet<fabric_drawing>();
            this.fabric_structure = new HashSet<fabric_structure>();
            this.fabric_warehouse = new HashSet<fabric_warehouse>();
            this.fabrics_product = new HashSet<fabrics_product>();
        }
    
        public string code { get; set; }
        public string name { get; set; }
        public double width { get; set; }
        public double length { get; set; }
        public double price { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fabric_color> fabric_color { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fabric_drawing> fabric_drawing { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fabric_structure> fabric_structure { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fabric_warehouse> fabric_warehouse { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fabrics_product> fabrics_product { get; set; }
    }
}
