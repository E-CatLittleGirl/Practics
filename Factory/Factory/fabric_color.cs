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
    
    public partial class fabric_color
    {
        public int id { get; set; }
        public string code_fabric { get; set; }
        public int id_color { get; set; }
    
        public virtual color color { get; set; }
        public virtual fabric fabric { get; set; }
    }
}
