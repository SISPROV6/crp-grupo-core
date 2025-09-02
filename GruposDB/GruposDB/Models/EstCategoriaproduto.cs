using System;
using System.Collections.Generic;

namespace GruposDB.Models;

public partial class EstCategoriaproduto
{
    public string CdCategoriaproduto { get; set; } = null!;

    public string? TxNome { get; set; }

    public virtual ICollection<EstProduto> EstProdutos { get; set; } = new List<EstProduto>();
}
