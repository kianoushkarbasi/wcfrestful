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
    
    public partial class CAT_TypesTexts
    {
        public CAT_TypesTexts()
        {
            this.CAT_ProductsLITypesTexts = new HashSet<CAT_ProductsLITypesTexts>();
        }
    
        public int TypeTextID { get; set; }
        public int ListItemTypeID { get; set; }
        public int ListItemTextID { get; set; }
        public Nullable<int> ViewOrder { get; set; }
    
        public virtual CAT_ListItemTypes CAT_ListItemTypes { get; set; }
        public virtual ICollection<CAT_ProductsLITypesTexts> CAT_ProductsLITypesTexts { get; set; }
    }
}
