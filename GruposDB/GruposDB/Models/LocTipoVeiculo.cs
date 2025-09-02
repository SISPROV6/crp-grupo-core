using System;
using System.Collections.Generic;

namespace GruposDB.Models;

public partial class LocTipoVeiculo
{
    public long Id { get; set; }

    public string Nome { get; set; } = null!;

    public virtual ICollection<LocVeiculo> LocVeiculos { get; set; } = new List<LocVeiculo>();
}
