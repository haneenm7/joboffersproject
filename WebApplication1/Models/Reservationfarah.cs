using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Reservationfarah
    {
        public decimal Reservationid { get; set; }
        public DateTime Reservationdate { get; set; }
        public decimal? Clinicid { get; set; }
        public decimal? Userid { get; set; }
        public decimal? Reservationtypeid { get; set; }
        public string Reservationcase { get; set; }
        public string Status { get; set; }
        public decimal? Petid { get; set; }

        public virtual Cliniccenterfarah Clinic { get; set; }
        public virtual Petfarah Pet { get; set; }
        public virtual Reservationtypefarah Reservationtype { get; set; }
        public virtual Useraccountfarah User { get; set; }
    }
}
