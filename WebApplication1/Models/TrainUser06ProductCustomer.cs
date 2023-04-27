using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class TrainUser06ProductCustomer
    {
        public decimal Id { get; set; }
        public decimal? ProductId { get; set; }
        public decimal CustomerId { get; set; }
        public decimal? Quantity { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public decimal TrainUser06ProductId { get; set; }
        public decimal TrainUser06CustomerId { get; set; }

        public virtual TrainUser06Product TrainUser06Product { get; set; }
    }
}
