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
    
    public partial class GetPermissionsByTab_Result
    {
        public int PermissionID { get; set; }
        public string PermissionCode { get; set; }
        public int ModuleDefID { get; set; }
        public string PermissionKey { get; set; }
        public string PermissionName { get; set; }
        public int ViewOrder { get; set; }
        public Nullable<int> CreatedByUserID { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public Nullable<int> LastModifiedByUserID { get; set; }
        public Nullable<System.DateTime> LastModifiedOnDate { get; set; }
    }
}
