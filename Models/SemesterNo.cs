//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApiLevel3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SemesterNo
    {
        public SemesterNo()
        {
            this.Semesters = new HashSet<Semester>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Semester> Semesters { get; set; }
    }
}
