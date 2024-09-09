using System;
using System.Collections.Generic;

namespace Meowgic.Repositories.Entities;

public partial class OrderDetail
{
    public int Id { get; set; }

    public int OrderId { get; set; }

    public int ServiceId { get; set; }

    public double? Rate { get; set; }

    public string? Feedback { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual TarotService Service { get; set; } = null!;
}
