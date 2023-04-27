using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Aboutuspety
    {
        public decimal Aboutid { get; set; }
        public string Titleimage { get; set; }
        public string Titletext { get; set; }
        public string Text1 { get; set; }
        public string Descriptiontext1 { get; set; }
        public string Text2 { get; set; }
        public string Descriptiontext2 { get; set; }
        public string Imagepath { get; set; }
        public decimal? Adoptid { get; set; }
        public decimal? Userid { get; set; }

        public virtual Adoptionfarah Adopt { get; set; }
        public virtual Useraccountfarah User { get; set; }
    }
}
