using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Loginl
    {
        public decimal Loginid { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public decimal? Roleid { get; set; }
        public decimal? Studentid { get; set; }

        public virtual Rolel Role { get; set; }
        public virtual Student Student { get; set; }
    }
}
