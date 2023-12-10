using System;
using System.Collections.Generic;

namespace zh3ujra1.Models;

public partial class Dolgozók
{
    public int DolgozóId { get; set; }

    public string? DolgozóNév { get; set; }

    public string? Munkaidő { get; set; }

    public int? ÜzletId { get; set; }

    public virtual ICollection<Ügyintézések> Ügyintézéseks { get; set; } = new List<Ügyintézések>();

    public virtual Üzletek? Üzlet { get; set; }
}
