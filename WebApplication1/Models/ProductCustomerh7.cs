﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class ProductCustomerh7
    {
        public decimal Id { get; set; }
        public decimal? ProductId { get; set; }
        public decimal? CustomerId { get; set; }
        public decimal? Quantity { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }

        public virtual Customerh7 Customer { get; set; }
        public virtual Producth7 Product { get; set; }
    }
}
