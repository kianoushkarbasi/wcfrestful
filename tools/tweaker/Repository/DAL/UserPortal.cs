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
    
    public partial class UserPortal
    {
        public int UserId { get; set; }
        public int PortalId { get; set; }
        public int UserPortalId { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public bool Authorised { get; set; }
        public bool IsDeleted { get; set; }
        public bool RefreshRoles { get; set; }
    
        public virtual Portal Portal { get; set; }
        public virtual User User { get; set; }
    }
}
