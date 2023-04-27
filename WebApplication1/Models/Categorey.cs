using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Categorey
    {
        public Categorey()
        {
            Courses = new HashSet<Course>();
        }

        public decimal Categoreyid { get; set; }
        public string Categoreyname { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
