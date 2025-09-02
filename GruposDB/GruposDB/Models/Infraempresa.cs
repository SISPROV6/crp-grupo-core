using System;
using System.Collections.Generic;

namespace GruposDB.Models;

public partial class Infraempresa
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Codigo { get; set; }

    public string? Nome { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<Infraestabelecimento> Infraestabelecimentos { get; set; } = new List<Infraestabelecimento>();
}
