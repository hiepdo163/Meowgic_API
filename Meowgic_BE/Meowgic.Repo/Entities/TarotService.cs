using System;
using System.Collections.Generic;

namespace Meowgic.Repositories.Entities;

public partial class TarotService
{
    public int Id { get; set; }

    public int AccountId { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? ImgUrl { get; set; }

    public double Price { get; set; }

    public double Rate { get; set; }

    public int? PromotionId { get; set; }

    public virtual Account Account { get; set; } = null!;

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = [];

    public virtual Promotion? Promotion { get; set; }
}
