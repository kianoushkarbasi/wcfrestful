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
    
    public partial class Module
    {
        public Module()
        {
            this.FAQs = new HashSet<FAQ>();
            this.HtmlTexts = new HashSet<HtmlText>();
            this.Links = new HashSet<Link>();
            this.ModulePermissions = new HashSet<ModulePermission>();
            this.ModuleSettings = new HashSet<ModuleSetting>();
            this.SearchItems = new HashSet<SearchItem>();
            this.TabModules = new HashSet<TabModule>();
            this.UserDefinedFields = new HashSet<UserDefinedField>();
            this.UserDefinedRows = new HashSet<UserDefinedRow>();
        }
    
        public int ModuleID { get; set; }
        public int ModuleDefID { get; set; }
        public bool AllTabs { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<bool> InheritViewPermissions { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<int> PortalID { get; set; }
        public Nullable<int> CreatedByUserID { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public Nullable<int> LastModifiedByUserID { get; set; }
        public Nullable<System.DateTime> LastModifiedOnDate { get; set; }
        public System.DateTime LastContentModifiedOnDate { get; set; }
        public Nullable<int> ContentItemID { get; set; }
    
        public virtual ContentItem ContentItem { get; set; }
        public virtual ICollection<FAQ> FAQs { get; set; }
        public virtual ICollection<HtmlText> HtmlTexts { get; set; }
        public virtual ICollection<Link> Links { get; set; }
        public virtual ModuleDefinition ModuleDefinition { get; set; }
        public virtual ICollection<ModulePermission> ModulePermissions { get; set; }
        public virtual Portal Portal { get; set; }
        public virtual ICollection<ModuleSetting> ModuleSettings { get; set; }
        public virtual ICollection<SearchItem> SearchItems { get; set; }
        public virtual ICollection<TabModule> TabModules { get; set; }
        public virtual ICollection<UserDefinedField> UserDefinedFields { get; set; }
        public virtual ICollection<UserDefinedRow> UserDefinedRows { get; set; }
    }
}
