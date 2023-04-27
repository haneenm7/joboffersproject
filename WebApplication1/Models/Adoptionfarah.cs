using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Adoptionfarah
    {
        public Adoptionfarah()
        {
            Aboutuspeties = new HashSet<Aboutuspety>();
        }

        public decimal Adoptionid { get; set; }
        public string Adoptionname { get; set; }
        public decimal? Adoptionage { get; set; }
        public decimal? Userid { get; set; }
        public string Imagepath { get; set; }
        public string Status { get; set; }
        public decimal? Pettypeid { get; set; }

        public virtual Pettypefarah Pettype { get; set; }
        public virtual Useraccountfarah User { get; set; }
        public virtual ICollection<Aboutuspety> Aboutuspeties { get; set; }
    }
}
