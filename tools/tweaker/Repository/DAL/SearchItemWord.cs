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
    
    public partial class SearchItemWord
    {
        public SearchItemWord()
        {
            this.SearchItemWordPositions = new HashSet<SearchItemWordPosition>();
        }
    
        public int SearchItemWordID { get; set; }
        public int SearchItemID { get; set; }
        public int SearchWordsID { get; set; }
        public int Occurrences { get; set; }
    
        public virtual SearchItem SearchItem { get; set; }
        public virtual SearchWord SearchWord { get; set; }
        public virtual ICollection<SearchItemWordPosition> SearchItemWordPositions { get; set; }
    }
}
