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
    
    public partial class CAT_ProductTypes
    {
        public CAT_ProductTypes()
        {
            this.CAT_SlotsProductTypes = new HashSet<CAT_SlotsProductTypes>();
            this.CAT_TypesSpecs = new HashSet<CAT_TypesSpecs>();
        }
    
        public int ProductTypeID { get; set; }
        public int PortalID { get; set; }
        public int CreatedByUser { get; set; }
        public string ProductTypeName { get; set; }
    
        public virtual Portal Portal { get; set; }
        public virtual ICollection<CAT_SlotsProductTypes> CAT_SlotsProductTypes { get; set; }
        public virtual ICollection<CAT_TypesSpecs> CAT_TypesSpecs { get; set; }
    }
}
