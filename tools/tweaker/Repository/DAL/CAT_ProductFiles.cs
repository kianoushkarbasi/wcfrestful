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
    
    public partial class CAT_ProductFiles
    {
        public CAT_ProductFiles()
        {
            this.CAT_OrderItemsLinks = new HashSet<CAT_OrderItemsLinks>();
        }
    
        public int FileID { get; set; }
        public int ProductID { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
        public string MediaType { get; set; }
        public Nullable<int> ViewOrder { get; set; }
        public string Title { get; set; }
        public string ButtonIcon { get; set; }
        public Nullable<int> ViewerID { get; set; }
        public string DisplayLocation { get; set; }
        public string ViewPermissions { get; set; }
        public Nullable<int> MaxNumberOfClicks { get; set; }
        public Nullable<int> AccessPeriod { get; set; }
        public string ReOrderLink { get; set; }
        public string POSelID { get; set; }
        public string MaxThumbWidth { get; set; }
        public string MaxThumbHeight { get; set; }
        public Nullable<int> CreatedByUserID { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public Nullable<int> LastModifiedByUserID { get; set; }
        public Nullable<System.DateTime> LastModifiedOnDate { get; set; }
    
        public virtual ICollection<CAT_OrderItemsLinks> CAT_OrderItemsLinks { get; set; }
        public virtual CAT_Products CAT_Products { get; set; }
    }
}