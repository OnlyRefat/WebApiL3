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
    
    public partial class Semester
    {
        public int Id { get; set; }
        public double Cgpa { get; set; }
        public int StudentId { get; set; }
        public Nullable<int> SemesterId { get; set; }
    
        public virtual SemesterNo SemesterNo { get; set; }
        public virtual Student Student { get; set; }
    }
}