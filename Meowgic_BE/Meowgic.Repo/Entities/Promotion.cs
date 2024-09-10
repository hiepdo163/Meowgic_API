using System;
using System.Collections.Generic;

namespace Meowgic.Repositories.Entities;

public partial class Promotion
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public double DiscountPercent { get; set; }

    public double MaxDiscount { get; set; }

    public DateTime ExpireTime { get; set; }

    public string? Status { get; set; }

    public virtual ICollection<TarotService> Services { get; set; } = new List<TarotService>();
}
