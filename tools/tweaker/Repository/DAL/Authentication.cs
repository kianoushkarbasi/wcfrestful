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
    
    public partial class Authentication
    {
        public int AuthenticationID { get; set; }
        public int PackageID { get; set; }
        public string AuthenticationType { get; set; }
        public bool IsEnabled { get; set; }
        public string SettingsControlSrc { get; set; }
        public string LoginControlSrc { get; set; }
        public string LogoffControlSrc { get; set; }
        public Nullable<int> CreatedByUserID { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public Nullable<int> LastModifiedByUserID { get; set; }
        public Nullable<System.DateTime> LastModifiedOnDate { get; set; }
    
        public virtual Package Package { get; set; }
    }
}
