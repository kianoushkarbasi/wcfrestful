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
    
    public partial class CAT_PriceHistory
    {
        public int PriceHistoryID { get; set; }
        public int ProductID { get; set; }
        public Nullable<System.DateTime> ChangeDate { get; set; }
        public Nullable<decimal> Price { get; set; }
    
        public virtual CAT_Products CAT_Products { get; set; }
    }
}