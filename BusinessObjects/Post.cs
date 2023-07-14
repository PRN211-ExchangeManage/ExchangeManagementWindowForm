using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class Post
    {
        public Post()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public int? UserId { get; set; }
        public DateTime? CreateAt { get; set; }
        public DateTime? Expire { get; set; }

        public virtual Account User { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
