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
    
    public partial class Flyer_TemplateRegions
    {
        public int RegionId { get; set; }
        public string RegionName { get; set; }
        public Nullable<int> Top { get; set; }
        public Nullable<int> Left { get; set; }
        public Nullable<int> Height { get; set; }
        public Nullable<int> Width { get; set; }
        public Nullable<int> TemplateId { get; set; }
    
        public virtual Flyer_Template Flyer_Template { get; set; }
    }
}