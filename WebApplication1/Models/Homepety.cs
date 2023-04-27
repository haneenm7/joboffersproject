using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Homepety
    {
        public decimal Homeid { get; set; }
        public string Titleimage { get; set; }
        public string Titletext { get; set; }
        public string Servicetitle { get; set; }
        public string Service1 { get; set; }
        public string Service2 { get; set; }
        public string Service3 { get; set; }
        public decimal? Userid { get; set; }

        public virtual Useraccountfarah User { get; set; }
    }
}
