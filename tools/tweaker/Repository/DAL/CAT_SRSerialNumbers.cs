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
    
    public partial class CAT_SRSerialNumbers
    {
        public int SerialNumberID { get; set; }
        public Nullable<int> ShippingRateID { get; set; }
        public string SerialNumber { get; set; }
        public Nullable<int> VendorID { get; set; }
        public Nullable<int> CreatedByUser { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> LastChangedByUser { get; set; }
        public Nullable<System.DateTime> LastChangeDate { get; set; }
        public Nullable<int> SNCategoryID { get; set; }
        public Nullable<int> OrderID { get; set; }
    }
}
