using System;
using System.Collections.Generic;

namespace GruposDB.Models;

public partial class EstLogAuditorium
{
    public long TenantId { get; set; }

    public long IdLog { get; set; }

    public string TxTabela { get; set; } = null!;

    public string TxAcaorealizada { get; set; } = null!;

    public DateTime DtAcaorealizada { get; set; }

    public string? TxDescricaodetalhada { get; set; }

    public string InfrausuarioId { get; set; } = null!;

    public virtual Infrausuario Infrausuario { get; set; } = null!;

    public virtual OssysTenant Tenant { get; set; } = null!;
}
