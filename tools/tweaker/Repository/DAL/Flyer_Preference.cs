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
    
    public partial class Flyer_Preference
    {
        public Flyer_Preference()
        {
            this.Flyer_Template_Preference = new HashSet<Flyer_Template_Preference>();
        }
    
        public int PreferenceID { get; set; }
        public string PreferenceTo { get; set; }
    
        public virtual ICollection<Flyer_Template_Preference> Flyer_Template_Preference { get; set; }
    }
}