using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class TrainUser06Category
    {
        public TrainUser06Category()
        {
            TrainUser06Products = new HashSet<TrainUser06Product>();
        }

        public decimal Id { get; set; }
        public string CategoryName { get; set; }
        public string ImagePath { get; set; }

        public virtual ICollection<TrainUser06Product> TrainUser06Products { get; set; }
    }
}
