using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Rolefarah
    {
        public Rolefarah()
        {
            Testmonialpeties = new HashSet<Testmonialpety>();
            Useraccountfarahs = new HashSet<Useraccountfarah>();
        }

        public decimal Roleid { get; set; }
        public string Rolename { get; set; }

        public virtual ICollection<Testmonialpety> Testmonialpeties { get; set; }
        public virtual ICollection<Useraccountfarah> Useraccountfarahs { get; set; }
    }
}
