using System;
using System.Collections.Generic;

namespace Sprint16.Models;

public partial class Order
{
    public int Id { get; set; }

    public int? CustomerId { get; set; }

    public int? SupermarketId { get; set; }

    public DateTime? OrderDate { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<OrderDetail> OrderDatails { get; } = new List<OrderDetail>();

    public virtual SuperMarket? Supermarket { get; set; }
}
