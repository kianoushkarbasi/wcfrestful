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
    
    public partial class Link
    {
        public int ItemID { get; set; }
        public int ModuleID { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public Nullable<int> ViewOrder { get; set; }
        public string Description { get; set; }
        public int CreatedByUser { get; set; }
    
        public virtual Module Module { get; set; }
    }
}
