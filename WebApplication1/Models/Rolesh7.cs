using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Rolesh7
    {
        public Rolesh7()
        {
            UserLoginh7s = new HashSet<UserLoginh7>();
        }

        public decimal Id { get; set; }
        public string Rolename { get; set; }

        public virtual ICollection<UserLoginh7> UserLoginh7s { get; set; }
    }
}
