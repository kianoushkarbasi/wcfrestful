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
    
    public partial class CAT_Periods
    {
        public int PeriodID { get; set; }
        public int ProductID { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<int> MinDays { get; set; }
        public Nullable<decimal> SeasonalPrice { get; set; }
        public Nullable<int> SeasonID { get; set; }
    
        public virtual CAT_Products CAT_Products { get; set; }
    }
}
