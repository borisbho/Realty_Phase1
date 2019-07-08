//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HomesDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class HomeTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HomeTable()
        {
            this.ShoppingCartLines = new HashSet<ShoppingCartLine>();
        }
    
        public int HomeID { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string HomeInfo { get; set; }
        public decimal Price { get; set; }
        public string HomeDetailOne { get; set; }
        public string HomeDetailTwo { get; set; }
        public string HomeDetailThree { get; set; }
        public string Image { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShoppingCartLine> ShoppingCartLines { get; set; }
    }
}
