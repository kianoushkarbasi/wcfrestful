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
    
    public partial class CAT_Posts
    {
        public int PostID { get; set; }
        public Nullable<int> ThreadID { get; set; }
        public Nullable<int> CreatedByUser { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string Body { get; set; }
    
        public virtual CAT_Threads CAT_Threads { get; set; }
    }
}
