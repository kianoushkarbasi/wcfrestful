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
    
    public partial class GetDesktopModulePermissions_Result
    {
        public int DesktopModulePermissionID { get; set; }
        public int PortalDesktopModuleID { get; set; }
        public Nullable<int> PermissionID { get; set; }
        public Nullable<int> RoleID { get; set; }
        public string RoleName { get; set; }
        public bool AllowAccess { get; set; }
        public Nullable<int> UserID { get; set; }
        public string Username { get; set; }
        public string DisplayName { get; set; }
        public string PermissionCode { get; set; }
        public Nullable<int> ModuleDefID { get; set; }
        public string PermissionKey { get; set; }
        public string PermissionName { get; set; }
        public Nullable<int> CreatedByUserID { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public Nullable<int> LastModifiedByUserID { get; set; }
        public Nullable<System.DateTime> LastModifiedOnDate { get; set; }
    }
}
