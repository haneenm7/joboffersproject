using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Course
    {
        public Course()
        {
            StdCourses = new HashSet<StdCourse>();
        }

        public decimal Courseid { get; set; }
        public string Coursename { get; set; }
        public decimal? Categoreyid { get; set; }
        public string Imagename { get; set; }

        public virtual Categorey Categorey { get; set; }
        public virtual ICollection<StdCourse> StdCourses { get; set; }
    }
}
