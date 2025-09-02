using System;
using System.Collections.Generic;

namespace GruposDB.Models;

public partial class EstUf
{
    public string CdUf { get; set; } = null!;

    public string? TxNome { get; set; }

    public virtual ICollection<EstEndereco> EstEnderecos { get; set; } = new List<EstEndereco>();
}
