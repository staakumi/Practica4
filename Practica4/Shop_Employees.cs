//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Practica4
{
    using System;
    using System.Collections.Generic;
    
    public partial class Shop_Employees
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Shop_Employees()
        {
            this.Products = new HashSet<Products>();
        }
    
        public int ID_Employees_Info { get; set; }
        public string Employees_Last_Name { get; set; }
        public string Employees_First_Name { get; set; }
        public string Employees_Middle_Name { get; set; }
        public int Employees_Age { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Products> Products { get; set; }
    }
}
