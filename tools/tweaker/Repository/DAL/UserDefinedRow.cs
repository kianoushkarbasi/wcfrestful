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
    
    public partial class UserDefinedRow
    {
        public UserDefinedRow()
        {
            this.UserDefinedDatas = new HashSet<UserDefinedData>();
        }
    
        public int UserDefinedRowId { get; set; }
        public int ModuleId { get; set; }
    
        public virtual Module Module { get; set; }
        public virtual ICollection<UserDefinedData> UserDefinedDatas { get; set; }
    }
}
