using System;
using System.Collections.Generic;

namespace Meowgic.Repositories.Entities;

public partial class Category
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<CardMeaning> CardMeanings { get; set; } = new List<CardMeaning>();

    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();
}
