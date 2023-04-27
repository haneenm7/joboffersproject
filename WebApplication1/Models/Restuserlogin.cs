using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Restuserlogin
    {
        public decimal Userloginid { get; set; }
        public string Username { get; set; }
        public string Passworde { get; set; }
        public decimal? Roleid { get; set; }
        public decimal? Customerid { get; set; }

        public virtual Restcustomer Customer { get; set; }
        public virtual Restrole Role { get; set; }
    }
}
