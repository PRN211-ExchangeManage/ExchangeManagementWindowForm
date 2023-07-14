using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class Order
    {
        public int Id { get; set; }
        public DateTime? BuyAt { get; set; }
        public string Address { get; set; }
        public int? BuyerId { get; set; }
        public int? ProductId { get; set; }
        public int? Quantity { get; set; }
        public double? TotalAmount { get; set; }

        public virtual Account Buyer { get; set; }
        public virtual Product Product { get; set; }
    }
}
