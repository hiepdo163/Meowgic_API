using System;
using System.Collections.Generic;

namespace Meowgic.Repositories.Entities;

public partial class Card
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string ImgUrl { get; set; } = null!;

    public virtual ICollection<CardMeaning> CardMeanings { get; set; } = new List<CardMeaning>();
}
