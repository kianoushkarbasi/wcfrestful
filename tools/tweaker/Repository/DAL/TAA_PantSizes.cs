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
    
    public partial class TAA_PantSizes
    {
        public TAA_PantSizes()
        {
            this.TAA_RoleCards = new HashSet<TAA_RoleCards>();
        }
    
        public int PantSizeID { get; set; }
        public int SizeGroupID { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
    
        public virtual TAA_SizeGroups TAA_SizeGroups { get; set; }
        public virtual ICollection<TAA_RoleCards> TAA_RoleCards { get; set; }
    }
}
