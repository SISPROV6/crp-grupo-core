using System;
using System.Collections.Generic;

namespace GruposDB.Models;

public partial class EstHistoricoLancamento
{
    public long TenantId { get; set; }

    public long IdHistorico { get; set; }

    public long Lancamentoid { get; set; }

    public string? TxComentario { get; set; }

    public string TxAcaoExecutada { get; set; } = null!;

    public DateTime DtEnvio { get; set; }

    public string Usuarioid { get; set; } = null!;

    public bool IsOrigemSistema { get; set; }

    public virtual EstLancamento Lancamento { get; set; } = null!;

    public virtual OssysTenant Tenant { get; set; } = null!;

    public virtual Infrausuario Usuario { get; set; } = null!;
}
