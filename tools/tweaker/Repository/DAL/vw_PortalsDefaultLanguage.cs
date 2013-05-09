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
    
    public partial class vw_PortalsDefaultLanguage
    {
        public int PortalID { get; set; }
        public Nullable<int> PortalGroupID { get; set; }
        public string PortalName { get; set; }
        public string LogoFile { get; set; }
        public string FooterText { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public int UserRegistration { get; set; }
        public int BannerAdvertising { get; set; }
        public Nullable<int> AdministratorId { get; set; }
        public string Currency { get; set; }
        public decimal HostFee { get; set; }
        public int HostSpace { get; set; }
        public int PageQuota { get; set; }
        public int UserQuota { get; set; }
        public Nullable<int> AdministratorRoleId { get; set; }
        public Nullable<int> RegisteredRoleId { get; set; }
        public string Description { get; set; }
        public string KeyWords { get; set; }
        public string BackgroundFile { get; set; }
        public System.Guid GUID { get; set; }
        public string PaymentProcessor { get; set; }
        public string ProcessorUserId { get; set; }
        public string ProcessorPassword { get; set; }
        public Nullable<int> SiteLogHistory { get; set; }
        public string Email { get; set; }
        public string DefaultLanguage { get; set; }
        public int TimezoneOffset { get; set; }
        public Nullable<int> AdminTabId { get; set; }
        public string HomeDirectory { get; set; }
        public Nullable<int> SplashTabId { get; set; }
        public Nullable<int> HomeTabId { get; set; }
        public Nullable<int> LoginTabId { get; set; }
        public Nullable<int> RegisterTabId { get; set; }
        public Nullable<int> UserTabId { get; set; }
        public Nullable<int> SearchTabId { get; set; }
        public Nullable<int> SuperTabId { get; set; }
        public Nullable<int> CreatedByUserID { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public Nullable<int> LastModifiedByUserID { get; set; }
        public Nullable<System.DateTime> LastModifiedOnDate { get; set; }
        public string CultureCode { get; set; }
    }
}
