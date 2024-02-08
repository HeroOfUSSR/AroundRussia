using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AroundRussia.Models
{
    public partial class PickUpPoint
    {
        public string PickUpCode { get; set; } = null!;
        public string PickUpAddress { get; set; } = null!;

        public virtual ICollection<Order> Orders { get; set; }
    }
}

