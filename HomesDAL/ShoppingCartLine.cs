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
    
    public partial class ShoppingCartLine
    {
        public int ShoppingCartLineID { get; set; }
        public int CartID { get; set; }
        public int HomeID { get; set; }
        public int Quanity { get; set; }
    
        public virtual HomeTable HomeTable { get; set; }
        public virtual ShoppingCart ShoppingCart { get; set; }
    }
}
