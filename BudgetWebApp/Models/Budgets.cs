//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BudgetWebApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Budgets
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Budgets()
        {
            this.BudgetRecords = new HashSet<BudgetRecords>();
        }
    
        public int BudgetID { get; set; }
        public int UserID { get; set; }
        public string BudgetName { get; set; }
        public int Income { get; set; }
        public int Expenses { get; set; }
        public int Balance { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BudgetRecords> BudgetRecords { get; set; }
        public virtual Users Users { get; set; }
    }
}
