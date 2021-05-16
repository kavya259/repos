using System;
using System.Collections.Generic;

#nullable disable

namespace BigBazarPresentationLayer.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserRole { get; set; }
    }
}
