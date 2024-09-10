using System;
using System.Collections.Generic;

namespace Meowgic.Repositories.Entities;

public partial class Order
{
    public int Id { get; set; }

    public int AccountId { get; set; }

    public decimal TotalPrice { get; set; }

    public DateTime OrderDate { get; set; }

    public string Status { get; set; } = null!;

    public virtual Account Account { get; set; } = null!;

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
