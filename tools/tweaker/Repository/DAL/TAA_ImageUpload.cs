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
    
    public partial class TAA_ImageUpload
    {
        public int Id { get; set; }
        public Nullable<int> UserId { get; set; }
        public string ImageName { get; set; }
        public Nullable<bool> IsError { get; set; }
        public Nullable<bool> IsFixIt { get; set; }
        public Nullable<System.DateTime> UploadedOnDate { get; set; }
    }
}
