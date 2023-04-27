using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class StdCourse
    {
        public decimal Id { get; set; }
        public decimal? Stdidid { get; set; }
        public decimal? Courseid { get; set; }
        public decimal? Markofstd { get; set; }
        public DateTime? Dateofregister { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Stdid { get; set; }
    }
}
