using System;
using System.Collections.Generic;

namespace zh3ujra1.Models;

public partial class Ügyfelek
{
    public int ÜgyfélId { get; set; }

    public string? Név { get; set; }

    public DateTime? SzülIdő { get; set; }

    public string? TelSzám { get; set; }

    public string? Email { get; set; }

    public int? CsomagId { get; set; }

    public bool? BővíthetőE { get; set; }

    public virtual Csomagok? Csomag { get; set; }

    public virtual ICollection<Ügyintézések> Ügyintézéseks { get; set; } = new List<Ügyintézések>();
}
