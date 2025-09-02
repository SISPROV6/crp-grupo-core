using System;
using System.Collections.Generic;

namespace GruposDB.Models;

public partial class EstProdutoLancto
{
    public long IdProdutolancamento { get; set; }

    public string ProdutoId { get; set; } = null!;

    public long LancamentoId { get; set; }

    public long QtProduto { get; set; }

    public DateTime DtPedido { get; set; }

    public decimal VlTotal { get; set; }

    public virtual EstLancamento Lancamento { get; set; } = null!;

    public virtual EstProduto Produto { get; set; } = null!;
}
