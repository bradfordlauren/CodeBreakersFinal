//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Code_BreakersEventBudget
{
    using System;
    using System.Collections.Generic;
    
    public partial class List
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public List()
        {
            this.ListItems = new HashSet<ListItem>();
        }
    
        public string Email { get; set; }
        public string ListID { get; set; }
        public string Discription { get; set; }
        public Nullable<decimal> Budget { get; set; }
        public string ListItemID { get; set; }
        public string Price { get; set; }
        public string GiftFor { get; set; }
        public string Product { get; set; }


        public virtual Personal_Info Personal_Info { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ListItem> ListItems { get; set; }
    }
}
