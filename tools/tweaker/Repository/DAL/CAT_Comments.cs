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
    
    public partial class CAT_Comments
    {
        public int CommentID { get; set; }
        public Nullable<int> FeedBackID { get; set; }
        public Nullable<int> CreatedByUser { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string Comment { get; set; }
    
        public virtual CAT_Feedbacks CAT_Feedbacks { get; set; }
    }
}
