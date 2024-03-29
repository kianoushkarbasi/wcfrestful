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
    
    public partial class Tab
    {
        public Tab()
        {
            this.TabModules = new HashSet<TabModule>();
            this.TabPermissions = new HashSet<TabPermission>();
            this.Tabs1 = new HashSet<Tab>();
            this.TabSettings = new HashSet<TabSetting>();
        }
    
        public int TabID { get; set; }
        public int TabOrder { get; set; }
        public Nullable<int> PortalID { get; set; }
        public string TabName { get; set; }
        public bool IsVisible { get; set; }
        public Nullable<int> ParentId { get; set; }
        public int Level { get; set; }
        public string IconFile { get; set; }
        public bool DisableLink { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string KeyWords { get; set; }
        public bool IsDeleted { get; set; }
        public string Url { get; set; }
        public string SkinSrc { get; set; }
        public string ContainerSrc { get; set; }
        public string TabPath { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<int> RefreshInterval { get; set; }
        public string PageHeadText { get; set; }
        public bool IsSecure { get; set; }
        public bool PermanentRedirect { get; set; }
        public double SiteMapPriority { get; set; }
        public Nullable<int> CreatedByUserID { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public Nullable<int> LastModifiedByUserID { get; set; }
        public Nullable<System.DateTime> LastModifiedOnDate { get; set; }
        public string IconFileLarge { get; set; }
        public string CultureCode { get; set; }
        public Nullable<int> ContentItemID { get; set; }
        public System.Guid UniqueId { get; set; }
        public System.Guid VersionGuid { get; set; }
        public Nullable<System.Guid> DefaultLanguageGuid { get; set; }
        public System.Guid LocalizedVersionGuid { get; set; }
    
        public virtual ContentItem ContentItem { get; set; }
        public virtual Portal Portal { get; set; }
        public virtual ICollection<TabModule> TabModules { get; set; }
        public virtual ICollection<TabPermission> TabPermissions { get; set; }
        public virtual ICollection<Tab> Tabs1 { get; set; }
        public virtual Tab Tab1 { get; set; }
        public virtual ICollection<TabSetting> TabSettings { get; set; }
    }
}
