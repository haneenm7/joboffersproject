using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Petfarah
    {
        public Petfarah()
        {
            Reservationfarahs = new HashSet<Reservationfarah>();
        }

        public decimal Petid { get; set; }
        public string Petname { get; set; }
        public decimal? Petage { get; set; }
        public decimal? Userid { get; set; }
        public decimal? Clinicid { get; set; }
        public decimal? Pettypeid { get; set; }
        public string Imagepath { get; set; }

        public virtual Cliniccenterfarah Clinic { get; set; }
        public virtual Pettypefarah Pettype { get; set; }
        public virtual Useraccountfarah User { get; set; }
        public virtual ICollection<Reservationfarah> Reservationfarahs { get; set; }
    }
}
