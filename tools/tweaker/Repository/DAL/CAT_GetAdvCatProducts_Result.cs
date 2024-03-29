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
    
    public partial class CAT_GetAdvCatProducts_Result
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductNumber { get; set; }
        public string EAN { get; set; }
        public string ISBN { get; set; }
        public string Free1 { get; set; }
        public string Free2 { get; set; }
        public string Free3 { get; set; }
        public string KeyWords { get; set; }
        public decimal UnitCost { get; set; }
        public Nullable<decimal> UnitCost2 { get; set; }
        public Nullable<decimal> UnitCost3 { get; set; }
        public Nullable<decimal> UnitCost4 { get; set; }
        public Nullable<decimal> UnitCost5 { get; set; }
        public Nullable<decimal> UnitCost6 { get; set; }
        public int BulkPriceLimit1 { get; set; }
        public int BulkPriceLimit2 { get; set; }
        public int BulkPriceLimit3 { get; set; }
        public int BulkPriceLimit4 { get; set; }
        public int BulkPriceLimit5 { get; set; }
        public string ProductImage { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        public Nullable<int> Stock { get; set; }
        public string OrderQuant { get; set; }
        public decimal SalePrice { get; set; }
        public Nullable<System.DateTime> SaleStart { get; set; }
        public Nullable<System.DateTime> SaleEnd { get; set; }
        public string Status { get; set; }
        public decimal ProductCost { get; set; }
        public bool PayPalSubscription { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public Nullable<int> Category2ID { get; set; }
        public string Category3 { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.DateTime> PublicationStart { get; set; }
        public Nullable<System.DateTime> PublicationEnd { get; set; }
        public Nullable<decimal> StartingPrice { get; set; }
        public Nullable<decimal> ReservePrice { get; set; }
        public string TaxCode { get; set; }
        public string HasOptions { get; set; }
        public string HasRequiredOptions { get; set; }
    }
}
