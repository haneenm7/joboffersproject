using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Categoryh7
    {
        public Categoryh7()
        {
            Producth7s = new HashSet<Producth7>();
        }

        public decimal Id { get; set; }
        public string CategoryName { get; set; }
        public string ImagePath { get; set; }

        public virtual ICollection<Producth7> Producth7s { get; set; }
    }
}
