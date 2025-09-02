using System;
using System.Collections.Generic;

namespace GruposDB.Models;

public partial class EstProduto
{
    public long TenantId { get; set; }

    public string IdProduto { get; set; } = null!;

    public string TxNome { get; set; } = null!;

    public string? TxDescricao { get; set; }

    public string? CategoriaCd { get; set; }

    public long? QtMinima { get; set; }

    public long? QtAtual { get; set; }

    public decimal? VlPrecoRecomendado { get; set; }

    public bool? IsActive { get; set; }

    public virtual EstCategoriaproduto? CategoriaCdNavigation { get; set; }

    public virtual ICollection<EstHistoricoPreco> EstHistoricoPrecos { get; set; } = new List<EstHistoricoPreco>();

    public virtual ICollection<EstProdutoLancto> EstProdutoLanctos { get; set; } = new List<EstProdutoLancto>();

    public virtual OssysTenant Tenant { get; set; } = null!;
}
