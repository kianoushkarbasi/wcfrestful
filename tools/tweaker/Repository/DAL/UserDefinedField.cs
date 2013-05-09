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
    
    public partial class UserDefinedField
    {
        public UserDefinedField()
        {
            this.UserDefinedDatas = new HashSet<UserDefinedData>();
            this.UserDefinedFieldSettings = new HashSet<UserDefinedFieldSetting>();
        }
    
        public int UserDefinedFieldId { get; set; }
        public int ModuleId { get; set; }
        public string FieldTitle { get; set; }
        public bool Visible { get; set; }
        public int FieldOrder { get; set; }
        public string FieldType { get; set; }
        public bool Required { get; set; }
        public string Default { get; set; }
        public string OutputSettings { get; set; }
        public string InputSettings { get; set; }
        public string ValidationRule { get; set; }
        public string ValidationMessage { get; set; }
        public bool NormalizeFlag { get; set; }
        public string HelpText { get; set; }
        public bool Searchable { get; set; }
        public bool ShowOnEdit { get; set; }
        public bool PrivateField { get; set; }
        public string EditStyle { get; set; }
        public bool MultipleValues { get; set; }
    
        public virtual Module Module { get; set; }
        public virtual ICollection<UserDefinedData> UserDefinedDatas { get; set; }
        public virtual ICollection<UserDefinedFieldSetting> UserDefinedFieldSettings { get; set; }
    }
}