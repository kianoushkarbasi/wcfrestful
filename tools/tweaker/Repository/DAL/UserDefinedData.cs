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
    
    public partial class UserDefinedData
    {
        public int UserDefinedFieldId { get; set; }
        public int UserDefinedRowId { get; set; }
        public string FieldValue { get; set; }
    
        public virtual UserDefinedField UserDefinedField { get; set; }
        public virtual UserDefinedRow UserDefinedRow { get; set; }
    }
}
