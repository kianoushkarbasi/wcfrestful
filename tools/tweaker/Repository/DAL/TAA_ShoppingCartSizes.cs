//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Repository.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class TAA_ShoppingCartSizes
    {
        public TAA_ShoppingCartSizes()
        {
            this.TAA_ShoppingCartAdjustments = new HashSet<TAA_ShoppingCartAdjustments>();
        }
    
        public int CartSizeID { get; set; }
        public int TAACartID { get; set; }
        public int SizeID { get; set; }
        public int Quantity { get; set; }
    
        public virtual TAA_ShoppingCart TAA_ShoppingCart { get; set; }
        public virtual ICollection<TAA_ShoppingCartAdjustments> TAA_ShoppingCartAdjustments { get; set; }
        public virtual TAA_Sizes TAA_Sizes { get; set; }
    }
}