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
    
    public partial class TAA_Colors
    {
        public int ColorID { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string RGB { get; set; }
        public Nullable<bool> Publish { get; set; }
        public Nullable<int> TAANumber { get; set; }
        public Nullable<int> ThreadColorID { get; set; }
        public Nullable<int> ButtonColorID { get; set; }
        public string taaAccountID { get; set; }
        public string CMYK { get; set; }
        public Nullable<int> ZipperColorID { get; set; }
    }
}