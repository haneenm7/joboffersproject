using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Restcategory
    {
        public Restcategory()
        {
            Restproducts = new HashSet<Restproduct>();
        }

        public decimal Categoryid { get; set; }
        public string Categoryname { get; set; }
        public string Imagepath { get; set; }

        public virtual ICollection<Restproduct> Restproducts { get; set; }
    }
}
