using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Rolel
    {
        public Rolel()
        {
            Loginls = new HashSet<Loginl>();
        }

        public decimal Roleid { get; set; }
        public string Rolename { get; set; }

        public virtual ICollection<Loginl> Loginls { get; set; }
    }
}
