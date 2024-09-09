using System;
using System.Collections.Generic;

namespace Meowgic.Repositories.Entities;

public partial class Question
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public int? CategoryId { get; set; }

    public virtual Category? Category { get; set; }
}
