using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AroundRussia.ModelResponse
{
    public class HotelResponse
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int CountOfStars { get; set; }
        public string CountryCode { get; set; } = null!;
        public string? Description { get; set; }

    }
}
