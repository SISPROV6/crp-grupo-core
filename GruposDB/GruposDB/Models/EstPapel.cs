using System;
using System.Collections.Generic;

namespace GruposDB.Models;

public partial class EstPapel
{
    public string CdPapel { get; set; } = null!;

    public string TxNome { get; set; } = null!;

    public virtual ICollection<EstPessoa> EstPessoas { get; set; } = new List<EstPessoa>();
}
