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
    
    public partial class order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public order()
        {
            this.cuttings = new HashSet<cutting>();
        }
    
        public int code { get; set; }
        public System.DateTime date { get; set; }
        public string status { get; set; }
        public int id_client { get; set; }
        public Nullable<int> id_manager { get; set; }
        public string code_product { get; set; }
        public int count { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cutting> cuttings { get; set; }
        public virtual product product { get; set; }
        public virtual user user { get; set; }
        public virtual user user1 { get; set; }
    }
}
