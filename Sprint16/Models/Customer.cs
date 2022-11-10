using System;
using System.Collections.Generic;

namespace Sprint16.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string? Fname { get; set; }

    public string? Lname { get; set; }

    public string? Adress { get; set; }

    public int? Dicsount { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
