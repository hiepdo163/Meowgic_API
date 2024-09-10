using System;
using System.Collections.Generic;

namespace Meowgic.Repositories.Entities;

public partial class Account
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Name { get; set; } = null!;

    public DateOnly? Dob { get; set; }

    public string? Gender { get; set; }

    public string? Phone { get; set; }

    public string Role { get; set; } = null!;

    public string Status { get; set; } = null!;

    public double? Rate { get; set; }

    public bool Premium { get; set; }

    public string? ImgUrl { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<TarotService> Services { get; set; } = new List<TarotService>();
}
