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
    
    public partial class furnitures_product
    {
        public int id { get; set; }
        public string code_product { get; set; }
        public string code_furniture { get; set; }
        public int count { get; set; }
    
        public virtual furniture furniture { get; set; }
        public virtual product product { get; set; }
    }
}
