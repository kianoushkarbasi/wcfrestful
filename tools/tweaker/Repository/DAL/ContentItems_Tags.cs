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
    
    public partial class ContentItems_Tags
    {
        public int ContentItemTagID { get; set; }
        public int ContentItemID { get; set; }
        public int TermID { get; set; }
    
        public virtual ContentItem ContentItem { get; set; }
        public virtual Taxonomy_Terms Taxonomy_Terms { get; set; }
    }
}
