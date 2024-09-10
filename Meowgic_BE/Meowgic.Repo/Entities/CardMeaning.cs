using System;
using System.Collections.Generic;

namespace Meowgic.Repositories.Entities;

public partial class CardMeaning
{
    public int CategoryId { get; set; }

    public int CardId { get; set; }

    public string Meaning { get; set; } = null!;

    public string? ReMeaning { get; set; }

    public virtual Card Card { get; set; } = null!;

    public virtual Category Category { get; set; } = null!;
}
