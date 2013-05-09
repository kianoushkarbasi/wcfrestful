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
    
    public partial class CAT_OrdersDetail_Result
    {
        public int ProductID { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public string ProductNumber { get; set; }
        public Nullable<bool> DownLoad { get; set; }
        public string DownLoadFile { get; set; }
        public string ZIPPassWord { get; set; }
        public Nullable<int> RoleID { get; set; }
        public Nullable<int> SubscriptionPeriod { get; set; }
        public Nullable<bool> RecurringBilling { get; set; }
        public string Status { get; set; }
        public int CreatedByUser { get; set; }
        public string EAN { get; set; }
        public string ISBN { get; set; }
        public string Free1 { get; set; }
        public string Free2 { get; set; }
        public string Free3 { get; set; }
        public bool DonationItem { get; set; }
        public string RoleExpiryType { get; set; }
        public string ItemDeliveryType { get; set; }
        public bool UseRoleFees { get; set; }
        public int OrderDetailsID { get; set; }
        public Nullable<decimal> UnitCost { get; set; }
        public int Quantity { get; set; }
        public int QuantityRemaining { get; set; }
        public int DeliveredUnits { get; set; }
        public Nullable<decimal> ExtendedAmount { get; set; }
        public Nullable<int> InvoiceNumber { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
        public Nullable<int> CreditNoteNumber { get; set; }
        public Nullable<System.DateTime> CreditNoteDate { get; set; }
        public string Options { get; set; }
        public Nullable<System.DateTime> AllocDate { get; set; }
        public Nullable<System.DateTime> SubscrExpiryDate { get; set; }
        public int RecordID { get; set; }
        public Nullable<int> BaseRecID { get; set; }
        public Nullable<int> ProductSlotID { get; set; }
        public Nullable<decimal> Tax { get; set; }
        public string ShippingCompany { get; set; }
        public string TrackingNumber { get; set; }
        public string SKU { get; set; }
        public int BillingPeriod { get; set; }
        public decimal Tax2 { get; set; }
        public string HasDownloads { get; set; }
        public Nullable<bool> Archive { get; set; }
        public string Description { get; set; }
        public Nullable<int> CartPriceRuleID { get; set; }
        public Nullable<int> PeriodsRemaining { get; set; }
    }
}