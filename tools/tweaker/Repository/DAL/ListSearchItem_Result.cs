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
    
    public partial class ListSearchItem_Result
    {
        public int SearchItemID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Nullable<int> Author { get; set; }
        public System.DateTime PubDate { get; set; }
        public int ModuleId { get; set; }
        public string SearchKey { get; set; }
        public string Guid { get; set; }
        public Nullable<int> HitCount { get; set; }
        public Nullable<int> ImageFileId { get; set; }
    }
}
