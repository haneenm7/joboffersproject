using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class TrainUser06UserLogin
    {
        public decimal Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public decimal? RoleId { get; set; }
        public decimal? CustomerId { get; set; }
        public decimal TrainUser06CustomerId { get; set; }
    }
}
