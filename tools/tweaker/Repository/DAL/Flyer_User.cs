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
    
    public partial class Flyer_User
    {
        public Flyer_User()
        {
            this.Flyer_Login = new HashSet<Flyer_Login>();
            this.Flyer_Order = new HashSet<Flyer_Order>();
        }
    
        public int UserID { get; set; }
        public string UserName { get; set; }
    
        public virtual ICollection<Flyer_Login> Flyer_Login { get; set; }
        public virtual ICollection<Flyer_Order> Flyer_Order { get; set; }
    }
}
