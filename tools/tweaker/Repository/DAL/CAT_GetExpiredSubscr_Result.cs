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
    
    public partial class CAT_GetExpiredSubscr_Result
    {
        public int OrderDetailsID { get; set; }
        public int RecordID { get; set; }
        public string Options { get; set; }
        public int OrderID { get; set; }
        public int QuantityRemaining { get; set; }
        public int DeliveredUnits { get; set; }
        public int ProductID { get; set; }
        public int BillingPeriod { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> SubscriptionPeriod { get; set; }
        public string PaymentType { get; set; }
    }
}