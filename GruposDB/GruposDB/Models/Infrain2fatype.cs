using System;
using System.Collections.Generic;

namespace GruposDB.Models;

public partial class Infrain2fatype
{
    public long Id { get; set; }

    public string? Nome { get; set; }

    public string? Codigo { get; set; }

    public int? Ordem { get; set; }

    public bool? IsActive { get; set; }
}
