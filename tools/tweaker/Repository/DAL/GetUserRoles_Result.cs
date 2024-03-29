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
    
    public partial class GetUserRoles_Result
    {
        public int UserRoleID { get; set; }
        public int RoleID { get; set; }
        public int UserID { get; set; }
        public int PortalID { get; set; }
        public string RoleName { get; set; }
        public string Username { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public Nullable<decimal> ServiceFee { get; set; }
        public string BillingFrequency { get; set; }
        public Nullable<int> TrialPeriod { get; set; }
        public string TrialFrequency { get; set; }
        public Nullable<int> BillingPeriod { get; set; }
        public Nullable<decimal> TrialFee { get; set; }
        public bool IsPublic { get; set; }
        public bool AutoAssignment { get; set; }
        public Nullable<int> RoleGroupID { get; set; }
        public string RSVPCode { get; set; }
        public string IconFile { get; set; }
        public Nullable<System.DateTime> EffectiveDate { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public Nullable<bool> IsTrialUsed { get; set; }
        public Nullable<int> CreatedByUserID { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public Nullable<int> LastModifiedByUserID { get; set; }
        public Nullable<System.DateTime> LastModifiedOnDate { get; set; }
    }
}
