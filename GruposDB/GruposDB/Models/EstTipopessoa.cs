using System;
using System.Collections.Generic;

namespace GruposDB.Models;

public partial class EstTipopessoa
{
    public string CdTipopessoa { get; set; } = null!;

    public string? TxTipopessoa { get; set; }

    public virtual ICollection<EstPessoa> EstPessoas { get; set; } = new List<EstPessoa>();
}
