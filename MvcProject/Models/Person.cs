//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Person
    {
        public Person()
        {
            this.Donations = new HashSet<Donation>();
        }
    
        public int PersonKey { get; set; }
        public string PersonLastName { get; set; }
        public string PersonFirstName { get; set; }
        public string PersonUsername { get; set; }
        public string PersonPlainPassword { get; set; }
        public Nullable<int> Personpasskey { get; set; }
        public Nullable<System.DateTime> PersonEntryDate { get; set; }
        public byte[] PersonUserPassword { get; set; }
    
        public virtual ICollection<Donation> Donations { get; set; }
    }
}
