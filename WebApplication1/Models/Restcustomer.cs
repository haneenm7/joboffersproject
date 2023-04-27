using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Restcustomer
    {
        public Restcustomer()
        {
            Restproductcustomers = new HashSet<Restproductcustomer>();
            Restuserlogins = new HashSet<Restuserlogin>();
        }

        public decimal Customerid { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Imagepath { get; set; }

        public virtual ICollection<Restproductcustomer> Restproductcustomers { get; set; }
        public virtual ICollection<Restuserlogin> Restuserlogins { get; set; }
    }
}
