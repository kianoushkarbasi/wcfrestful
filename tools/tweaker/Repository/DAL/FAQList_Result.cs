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
    
    public partial class FAQList_Result
    {
        public int ItemId { get; set; }
        public int ModuleId { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public string CreatedByUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime DateModified { get; set; }
        public int ViewCount { get; set; }
    }
}