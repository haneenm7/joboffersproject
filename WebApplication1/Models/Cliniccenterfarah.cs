using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Cliniccenterfarah
    {
        public Cliniccenterfarah()
        {
            Petfarahs = new HashSet<Petfarah>();
            Reservationfarahs = new HashSet<Reservationfarah>();
        }

        public decimal Clinicid { get; set; }
        public string Clinicname { get; set; }
        public string Cliniclocation { get; set; }
        public string Clinicsatus { get; set; }
        public string Imagepath { get; set; }

        public virtual ICollection<Petfarah> Petfarahs { get; set; }
        public virtual ICollection<Reservationfarah> Reservationfarahs { get; set; }
    }
}
