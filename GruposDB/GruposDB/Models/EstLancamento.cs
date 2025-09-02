using System;
using System.Collections.Generic;

namespace GruposDB.Models;

public partial class EstLancamento
{
    public long TenantId { get; set; }

    public long Id { get; set; }

    public string TipolancamentoCd { get; set; } = null!;

    public string PessoaId { get; set; } = null!;

    public string? TxCodigobarras { get; set; }

    public string SituacaoCd { get; set; } = null!;

    public DateTime? DtLancamento { get; set; }

    public decimal? VlLancamento { get; set; }

    public DateTime? DtPagamento { get; set; }

    public string? TxDescricao { get; set; }

    public bool? IsActive { get; set; }

    public string Estabelecimentoid { get; set; } = null!;

    public decimal? VlDesconto { get; set; }

    public decimal? VlImposto { get; set; }

    public DateTime DtVencimento { get; set; }

    public string PessoaRemetenteId { get; set; } = null!;

    public string PessoaDestinatarioId { get; set; } = null!;

    public virtual ICollection<EstAnexoLancamento> EstAnexoLancamentos { get; set; } = new List<EstAnexoLancamento>();

    public virtual ICollection<EstHistoricoLancamento> EstHistoricoLancamentos { get; set; } = new List<EstHistoricoLancamento>();

    public virtual ICollection<EstProdutoLancto> EstProdutoLanctos { get; set; } = new List<EstProdutoLancto>();

    public virtual Infraestabelecimento Estabelecimento { get; set; } = null!;

    public virtual EstPessoa Pessoa { get; set; } = null!;

    public virtual EstPessoa PessoaDestinatario { get; set; } = null!;

    public virtual EstPessoa PessoaRemetente { get; set; } = null!;

    public virtual EstSituacaolancamento SituacaoCdNavigation { get; set; } = null!;

    public virtual OssysTenant Tenant { get; set; } = null!;

    public virtual EstTipolancamento TipolancamentoCdNavigation { get; set; } = null!;
}
