using System;
using System.Collections.Generic;

namespace GruposDB.Models;

public partial class EstPessoa
{
    public long TenantId { get; set; }

    public string IdPessoa { get; set; } = null!;

    public string TxNomepessoa { get; set; } = null!;

    public string TipopessoaCd { get; set; } = null!;

    public string PapelCd { get; set; } = null!;

    public string TxDocumento { get; set; } = null!;

    public DateTime? DtNascimento { get; set; }

    public DateTime? DtFundacao { get; set; }

    public DateTime DtIniciovinculo { get; set; }

    public DateTime DtCriacao { get; set; }

    public DateTime? DtUltimaalteracao { get; set; }

    public bool? IsActive { get; set; }

    public bool IsEstrangeiro { get; set; }

    public virtual ICollection<EstContato> EstContatos { get; set; } = new List<EstContato>();

    public virtual ICollection<EstEndereco> EstEnderecos { get; set; } = new List<EstEndereco>();

    public virtual ICollection<EstLancamento> EstLancamentoPessoaDestinatarios { get; set; } = new List<EstLancamento>();

    public virtual ICollection<EstLancamento> EstLancamentoPessoaRemetentes { get; set; } = new List<EstLancamento>();

    public virtual ICollection<EstLancamento> EstLancamentoPessoas { get; set; } = new List<EstLancamento>();

    public virtual EstPapel PapelCdNavigation { get; set; } = null!;

    public virtual OssysTenant Tenant { get; set; } = null!;

    public virtual EstTipopessoa TipopessoaCdNavigation { get; set; } = null!;
}
