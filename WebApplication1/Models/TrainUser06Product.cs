using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class TrainUser06Product
    {
        public TrainUser06Product()
        {
            TrainUser06ProductCustomers = new HashSet<TrainUser06ProductCustomer>();
        }

        public decimal Id { get; set; }
        public string Namee { get; set; }
        public decimal? Sale { get; set; }
        public decimal? Price { get; set; }
        public decimal? CategoryId { get; set; }
        public decimal TrainUser06CategoryId { get; set; }

        public virtual TrainUser06Category TrainUser06Category { get; set; }
        public virtual ICollection<TrainUser06ProductCustomer> TrainUser06ProductCustomers { get; set; }
    }
}
