using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Restrole
    {
        public Restrole()
        {
            Restuserlogins = new HashSet<Restuserlogin>();
        }

        public decimal Roleid { get; set; }
        public string Rolename { get; set; }

        public virtual ICollection<Restuserlogin> Restuserlogins { get; set; }
    }
}
