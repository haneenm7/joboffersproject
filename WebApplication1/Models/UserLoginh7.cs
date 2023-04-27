﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class UserLoginh7
    {
        public decimal Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public decimal? RoleId { get; set; }
        public decimal? CustomerId { get; set; }

        public virtual Customerh7 Customer { get; set; }
        public virtual Rolesh7 Role { get; set; }
    }
}