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
    
    public partial class CAT_MainZones
    {
        public CAT_MainZones()
        {
            this.CAT_SubZones = new HashSet<CAT_SubZones>();
        }
    
        public int MainZoneID { get; set; }
        public Nullable<int> PortalID { get; set; }
        public Nullable<int> ZoneNameID { get; set; }
        public string CountryCode { get; set; }
        public string StateCode { get; set; }
        public Nullable<decimal> Tax { get; set; }
        public Nullable<bool> TaxShipping { get; set; }
        public string TaxRateName { get; set; }
    
        public virtual Portal Portal { get; set; }
        public virtual ICollection<CAT_SubZones> CAT_SubZones { get; set; }
    }
}