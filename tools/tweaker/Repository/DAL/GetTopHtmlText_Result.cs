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
    
    public partial class GetTopHtmlText_Result
    {
        public int ModuleID { get; set; }
        public int ItemID { get; set; }
        public string Content { get; set; }
        public Nullable<int> Version { get; set; }
        public Nullable<int> StateID { get; set; }
        public Nullable<bool> IsPublished { get; set; }
        public Nullable<int> CreatedByUserID { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public Nullable<int> LastModifiedByUserID { get; set; }
        public Nullable<System.DateTime> LastModifiedOnDate { get; set; }
        public string Summary { get; set; }
        public int StateID1 { get; set; }
        public int WorkflowID { get; set; }
        public string StateName { get; set; }
        public int Order { get; set; }
        public bool IsActive { get; set; }
        public bool Notify { get; set; }
        public string WorkflowName { get; set; }
        public string DisplayName { get; set; }
        public Nullable<int> PortalID { get; set; }
    }
}