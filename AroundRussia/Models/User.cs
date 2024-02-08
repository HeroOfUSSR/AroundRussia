using System;
using System.Collections.Generic;

namespace AroundRussia.Models
{
    public partial class User
    {
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int RoleId { get; set; }

        public string? FIO { get; set; }
        public virtual Role Role { get; set; } = null!;
    }
}
