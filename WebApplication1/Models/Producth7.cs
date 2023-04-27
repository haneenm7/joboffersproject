using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Producth7
    {
        public Producth7()
        {
            ProductCustomerh7s = new HashSet<ProductCustomerh7>();
        }

        public decimal Id { get; set; }
        public string Name { get; set; }
        public decimal? Sale { get; set; }
        public decimal? Price { get; set; }
        public decimal? CategoryId { get; set; }

        public virtual Categoryh7 Category { get; set; }
        public virtual ICollection<ProductCustomerh7> ProductCustomerh7s { get; set; }
    }
}
