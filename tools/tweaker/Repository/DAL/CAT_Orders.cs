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
    
    public partial class CAT_Orders
    {
        public CAT_Orders()
        {
            this.CAT_OrderDetails = new HashSet<CAT_OrderDetails>();
            this.TAA_CouponAdjustments = new HashSet<TAA_CouponAdjustments>();
            this.TAA_OrdersAdjustments = new HashSet<TAA_OrdersAdjustments>();
        }
    
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public System.DateTime OrderDate { get; set; }
        public Nullable<System.DateTime> ShipDate { get; set; }
        public Nullable<int> ShipToID { get; set; }
        public string PaymentType { get; set; }
        public string PaymentState { get; set; }
        public Nullable<decimal> ShipCosts { get; set; }
        public Nullable<decimal> ShipTax { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public decimal ShipTax2 { get; set; }
        public Nullable<int> ReferralID { get; set; }
        public bool AACodeSent { get; set; }
        public Nullable<int> CreatedByUserID { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public Nullable<int> LastModifiedByUserID { get; set; }
        public Nullable<System.DateTime> LastModifiedOnDate { get; set; }
        public string ShippingMethod { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public string taaDeliveryMode { get; set; }
        public Nullable<decimal> ShippingRebate { get; set; }
        public string Carrier { get; set; }
        public Nullable<decimal> DeclaredValue { get; set; }
        public Nullable<int> MicrositeID { get; set; }
        public Nullable<int> CouponID { get; set; }
        public Nullable<decimal> CouponRebate { get; set; }
    
        public virtual ICollection<CAT_OrderDetails> CAT_OrderDetails { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<TAA_CouponAdjustments> TAA_CouponAdjustments { get; set; }
        public virtual ICollection<TAA_OrdersAdjustments> TAA_OrdersAdjustments { get; set; }
    }
}
