using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Student
    {
        public Student()
        {
            Loginls = new HashSet<Loginl>();
            StdCourses = new HashSet<StdCourse>();
        }

        public decimal Studentid { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime? Dateofbirth { get; set; }

        public virtual ICollection<Loginl> Loginls { get; set; }
        public virtual ICollection<StdCourse> StdCourses { get; set; }
    }
}
