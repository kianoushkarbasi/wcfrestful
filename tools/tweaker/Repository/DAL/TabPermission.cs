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
    
    public partial class TabPermission
    {
        public int TabPermissionID { get; set; }
        public int TabID { get; set; }
        public int PermissionID { get; set; }
        public bool AllowAccess { get; set; }
        public Nullable<int> RoleID { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> CreatedByUserID { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public Nullable<int> LastModifiedByUserID { get; set; }
        public Nullable<System.DateTime> LastModifiedOnDate { get; set; }
    
        public virtual Permission Permission { get; set; }
        public virtual Tab Tab { get; set; }
        public virtual User User { get; set; }
    }
}
