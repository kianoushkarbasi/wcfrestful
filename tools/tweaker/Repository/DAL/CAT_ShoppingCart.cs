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
    
    public partial class CAT_ShoppingCart
    {
        public int RecordID { get; set; }
        public string CartID { get; set; }
        public int Quantity { get; set; }
        public int ProductID { get; set; }
        public Nullable<decimal> UnitCost { get; set; }
        public string Options { get; set; }
        public Nullable<System.DateTime> AllocDate { get; set; }
        public Nullable<int> BaseRecID { get; set; }
        public Nullable<int> ProductSlotID { get; set; }
        public Nullable<bool> ConfigCompleted { get; set; }
        public Nullable<decimal> Tax { get; set; }
        public System.DateTime DateCreated { get; set; }
        public string SKU { get; set; }
        public int BillingPeriod { get; set; }
        public decimal Tax2 { get; set; }
        public Nullable<int> CouponCodeID { get; set; }
        public Nullable<int> CartPriceRuleID { get; set; }
        public Nullable<decimal> LoyaltyDiscount { get; set; }
        public Nullable<int> PeriodsRemaining { get; set; }
        public Nullable<int> CouponID { get; set; }
    
        public virtual CAT_Products CAT_Products { get; set; }
    }
}