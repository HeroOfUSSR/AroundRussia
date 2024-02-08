using System;
using System.Collections.Generic;

namespace AroundRussia.Models
{
    public partial class Order
    {
        public int IdOrder { get; set; }
        public DateTimeOffset? DateOrder { get; set; }
        public string TourId { get; set; } = null!;
        public int Amount { get; set; }
        public int Cost { get; set; }
        public double? Discount { get; set; }
        public string CodePickUp { get; set; } = null!;

        public virtual Tour Tour { get; set; } = null!;

        public virtual PickUpPoint PickUpPoint { get; set; } = null!;
    }
}
