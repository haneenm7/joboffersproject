using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Customerh7
    {
        public Customerh7()
        {
            ProductCustomerh7s = new HashSet<ProductCustomerh7>();
            UserLoginh7s = new HashSet<UserLoginh7>();
        }

        public decimal Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string ImagePath { get; set; }

        public virtual ICollection<ProductCustomerh7> ProductCustomerh7s { get; set; }
        public virtual ICollection<UserLoginh7> UserLoginh7s { get; set; }
    }
}
