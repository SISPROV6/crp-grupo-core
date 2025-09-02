using System;
using System.Collections.Generic;

namespace GruposDB.Models;

public partial class EstSituacaolancamento
{
    public string CdSituacaolancamento { get; set; } = null!;

    public string? TxNome { get; set; }

    public virtual ICollection<EstLancamento> EstLancamentos { get; set; } = new List<EstLancamento>();
}
