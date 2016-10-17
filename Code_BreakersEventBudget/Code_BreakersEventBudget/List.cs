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
    using System.ComponentModel.DataAnnotations;

    public partial class List
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public List()
        {
            this.ListItems = new HashSet<ListItem>();
        }

    
        public int ListID { get; set; }
        public int UserID { get; set; }
        //[Required(ErrorMessage = "Please enter the Event you want to shop for")]
        //[RegularExpression(@"^[A-Z]+[a-z]", ErrorMessage = "Please enter your name (only string)")]
        //[StringLength(30, ErrorMessage = "up to 30 character")]
        public string Description { get; set; }
        //[Required(ErrorMessage = "Please enter your Budget")]
        //[DataType(DataType.Currency)]
        public decimal Budget { get; set; }

        [DataType(DataType.Date)]
        public Nullable<System.DateTime> EventDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ListItem> ListItems { get; set; }
        public virtual PersonalInfo PersonalInfo { get; set; }
    }
}
