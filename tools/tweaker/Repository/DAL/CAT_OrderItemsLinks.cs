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
    
    public partial class CAT_OrderItemsLinks
    {
        public int OrderItemsLinksID { get; set; }
        public int OrderDetailsID { get; set; }
        public int FileID { get; set; }
        public Nullable<int> Clicks { get; set; }
        public int MaxNumberOfClicks { get; set; }
        public Nullable<System.DateTime> FirstClick { get; set; }
        public int AccessPeriod { get; set; }
    
        public virtual CAT_ProductFiles CAT_ProductFiles { get; set; }
    }
}