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
    
    public partial class CAT_GetAllAdvCats_Result
    {
        public int AdvCatID { get; set; }
        public int AdvCatOrder { get; set; }
        public Nullable<int> PortalID { get; set; }
        public string AdvCatName { get; set; }
        public bool IsVisible { get; set; }
        public Nullable<int> ParentId { get; set; }
        public int Level { get; set; }
        public string IconFile { get; set; }
        public bool DisableLink { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string KeyWords { get; set; }
        public string AdvCatImportID { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string URL { get; set; }
        public string HasChildren { get; set; }
    }
}
