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
    
    public partial class CAT_vw_ShoppingCartRollCall
    {
        public string CartID { get; set; }
        public int TAACartID { get; set; }
        public Nullable<int> RoleCardID { get; set; }
        public int ProductID { get; set; }
        public int RecordID { get; set; }
        public Nullable<int> FanID { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> JerseyNumber { get; set; }
        public string PrintedName { get; set; }
        public string ProductImage { get; set; }
        public Nullable<decimal> UnitCost { get; set; }
        public string CMSProductDesign { get; set; }
        public int SizeID { get; set; }
        public string SizeDisplay { get; set; }
        public string primaryColorHex { get; set; }
        public string secondaryColorHex { get; set; }
        public string accentColorHex { get; set; }
        public Nullable<int> quantity { get; set; }
    }
}