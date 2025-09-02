using System;
using System.Collections.Generic;

namespace GruposDB.Models;

public partial class Infraestabfavorito
{
    public int TenantId { get; set; }

    public long Id { get; set; }

    public string? Infrausuarioid { get; set; }

    public string? Infraestabid { get; set; }

    public bool? IsDefault { get; set; }

    public bool? IsFavorite { get; set; }
}
