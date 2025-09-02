using System;
using System.Collections.Generic;

namespace GruposDB.Models;

public partial class EstTipolancamento
{
    public string CdTipo { get; set; } = null!;

    public string TxTipolancamento { get; set; } = null!;

    public virtual ICollection<EstLancamento> EstLancamentos { get; set; } = new List<EstLancamento>();
}
