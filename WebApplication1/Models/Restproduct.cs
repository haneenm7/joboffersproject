using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Restproduct
    {
        public Restproduct()
        {
            Restproductcustomers = new HashSet<Restproductcustomer>();
        }

        public decimal Productid { get; set; }
        public string Productname { get; set; }
        public decimal? Productsale { get; set; }
        public decimal? Productprice { get; set; }
        public decimal? Categoryid { get; set; }

        public virtual Restcategory Category { get; set; }
        public virtual ICollection<Restproductcustomer> Restproductcustomers { get; set; }
    }
}
