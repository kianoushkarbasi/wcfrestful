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
    
    public partial class TAA_SizeGroups
    {
        public TAA_SizeGroups()
        {
            this.TAA_PantSizes = new HashSet<TAA_PantSizes>();
            this.TAA_ShirtSizes = new HashSet<TAA_ShirtSizes>();
        }
    
        public int SizeGroupID { get; set; }
        public string Gender { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<TAA_PantSizes> TAA_PantSizes { get; set; }
        public virtual ICollection<TAA_ShirtSizes> TAA_ShirtSizes { get; set; }
    }
}
