using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Useraccountfarah
    {
        public Useraccountfarah()
        {
            Aboutuspeties = new HashSet<Aboutuspety>();
            Adoptionfarahs = new HashSet<Adoptionfarah>();
            Homepeties = new HashSet<Homepety>();
            Petfarahs = new HashSet<Petfarah>();
            Reservationfarahs = new HashSet<Reservationfarah>();
            Testmonialpeties = new HashSet<Testmonialpety>();
        }

        public decimal Userid { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public decimal? Roleid { get; set; }
        public string Firstname { get; set; }
        public string Lastnamename { get; set; }
        public string Imagepath { get; set; }
        public string Phonenum { get; set; }

        public virtual Rolefarah Role { get; set; }
        public virtual ICollection<Aboutuspety> Aboutuspeties { get; set; }
        public virtual ICollection<Adoptionfarah> Adoptionfarahs { get; set; }
        public virtual ICollection<Homepety> Homepeties { get; set; }
        public virtual ICollection<Petfarah> Petfarahs { get; set; }
        public virtual ICollection<Reservationfarah> Reservationfarahs { get; set; }
        public virtual ICollection<Testmonialpety> Testmonialpeties { get; set; }
    }
}
