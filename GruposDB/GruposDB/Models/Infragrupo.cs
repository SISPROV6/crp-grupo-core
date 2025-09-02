using System;
using System.Collections.Generic;

namespace GruposDB.Models;

public partial class Infragrupo
{
    public int TenantId { get; set; }

    public long Id { get; set; }

    public string? Nome { get; set; }

    public string? Descricao { get; set; }
}
