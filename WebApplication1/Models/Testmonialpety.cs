using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Testmonialpety
    {
        public decimal Testid { get; set; }
        public string Testcontent { get; set; }
        public string Teststatus { get; set; }
        public decimal? Userid { get; set; }
        public decimal? Roleid { get; set; }

        public virtual Rolefarah Role { get; set; }
        public virtual Useraccountfarah User { get; set; }
    }
}
