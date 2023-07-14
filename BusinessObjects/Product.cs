using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class Product
    {
        public Product()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? CategoryId { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int? PostId { get; set; }
        public double? Price { get; set; }
        public int? Quantity { get; set; }

        public virtual Category Category { get; set; }
        public virtual Post Post { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
