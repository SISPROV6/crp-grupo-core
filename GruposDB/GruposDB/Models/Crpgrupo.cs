using System;
using System.Collections.Generic;

namespace GruposDB.Models;

public partial class Crpgrupo
{
    public int TenantId { get; set; }

    public long Idcrpgrupo { get; set; }

    public string? Codigo { get; set; }

    public string? Descricao { get; set; }

    public bool? Isgrupofinal { get; set; }

    public int? Numeronivel { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsCatalogo { get; set; }
}
