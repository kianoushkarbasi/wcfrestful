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
    
    public partial class TAA_Sizes
    {
        public TAA_Sizes()
        {
            this.TAA_ProductSizes = new HashSet<TAA_ProductSizes>();
            this.TAA_ShoppingCartSizes = new HashSet<TAA_ShoppingCartSizes>();
        }
    
        public int id { get; set; }
        public string GroupName { get; set; }
        public string Displayname { get; set; }
        public string Sizenumber { get; set; }
        public Nullable<int> SortOrder { get; set; }
    
        public virtual ICollection<TAA_ProductSizes> TAA_ProductSizes { get; set; }
        public virtual ICollection<TAA_ShoppingCartSizes> TAA_ShoppingCartSizes { get; set; }
    }
}