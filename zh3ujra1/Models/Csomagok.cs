using System;
using System.Collections.Generic;

namespace zh3ujra1.Models;

public partial class Csomagok
{
    public int CsomagId { get; set; }

    public string? CsomagNév { get; set; }

    public int? Mobilnet { get; set; }

    public int? Percek { get; set; }

    public int? Időtartam { get; set; }

    public string? FizÜtemezés { get; set; }

    public decimal? ÉvesKedvezmény { get; set; }

    public int? Ár { get; set; }

    public virtual ICollection<Ügyfelek> Ügyfeleks { get; set; } = new List<Ügyfelek>();
}
