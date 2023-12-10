using System;
using System.Collections.Generic;

namespace zh3ujra1.Models;

public partial class Üzletek
{
    public int ÜzletId { get; set; }

    public string? ÜzletNév { get; set; }

    public string? Helyszín { get; set; }

    public int? Üzletvezető { get; set; }

    public string? Méret { get; set; }

    public int? TavalyiVásárlóSzám { get; set; }

    public bool? KülönállóE { get; set; }

    public virtual ICollection<Dolgozók> Dolgozóks { get; set; } = new List<Dolgozók>();
}
