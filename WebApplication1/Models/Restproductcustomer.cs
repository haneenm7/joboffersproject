using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Restproductcustomer
    {
        public decimal Productcustomerid { get; set; }
        public decimal? Productid { get; set; }
        public decimal? Customerid { get; set; }
        public decimal? Quantity { get; set; }
        public DateTime? Datefrom { get; set; }
        public DateTime? Dateto { get; set; }

        public virtual Restcustomer Customer { get; set; }
        public virtual Restproduct Product { get; set; }
    }
}
