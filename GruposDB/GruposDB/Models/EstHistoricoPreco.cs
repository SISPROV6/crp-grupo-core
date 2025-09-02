using System;
using System.Collections.Generic;

namespace GruposDB.Models;

public partial class EstHistoricoPreco
{
    public long TenantId { get; set; }

    public long IdHistorico { get; set; }

    public string ProdutoId { get; set; } = null!;

    public DateTime? DtVigencia { get; set; }

    public decimal? VlNovopreco { get; set; }

    public decimal VlPrecoanterior { get; set; }

    public virtual EstProduto Produto { get; set; } = null!;

    public virtual OssysTenant Tenant { get; set; } = null!;
}
