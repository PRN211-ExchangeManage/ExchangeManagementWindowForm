using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class Account
    {
        public Account()
        {
            Orders = new HashSet<Order>();
            Posts = new HashSet<Post>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int? Role { get; set; }
        public bool? Status { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
