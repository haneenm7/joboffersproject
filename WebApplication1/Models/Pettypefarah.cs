using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Pettypefarah
    {
        public Pettypefarah()
        {
            Adoptionfarahs = new HashSet<Adoptionfarah>();
            Petfarahs = new HashSet<Petfarah>();
        }

        public decimal Pettypeid { get; set; }
        public string Pettypename { get; set; }

        public virtual ICollection<Adoptionfarah> Adoptionfarahs { get; set; }
        public virtual ICollection<Petfarah> Petfarahs { get; set; }
    }
}
