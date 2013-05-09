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
    
    public partial class TAA_vw_OrderDetailsRollCall
    {
        public int OrderID { get; set; }
        public int TAACartID { get; set; }
        public Nullable<int> RoleCardID { get; set; }
        public int ProductID { get; set; }
        public int RecordID { get; set; }
        public Nullable<int> FanID { get; set; }
        public int CustomerID { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> JerseyNumber { get; set; }
        public string PrintedName { get; set; }
        public string ProductImage { get; set; }
        public decimal UnitCost { get; set; }
        public Nullable<decimal> Tax { get; set; }
        public Nullable<decimal> ShipCosts { get; set; }
        public Nullable<decimal> ShippingRebate { get; set; }
        public Nullable<decimal> ShipTax { get; set; }
        public string ShippingMethod { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public string CMSProductDesign { get; set; }
        public int SizeID { get; set; }
        public string SizeDisplay { get; set; }
        public Nullable<int> primaryColorId { get; set; }
        public Nullable<int> secondaryColorId { get; set; }
        public Nullable<int> accentColorId { get; set; }
        public Nullable<int> quantity { get; set; }
        public Nullable<int> CMSProductID { get; set; }
        public Nullable<int> DiscountClassID { get; set; }
    }
}
