using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Reservationtypefarah
    {
        public Reservationtypefarah()
        {
            Reservationfarahs = new HashSet<Reservationfarah>();
        }

        public decimal Reservationtypeid { get; set; }
        public string Reservationtypename { get; set; }

        public virtual ICollection<Reservationfarah> Reservationfarahs { get; set; }
    }
}
