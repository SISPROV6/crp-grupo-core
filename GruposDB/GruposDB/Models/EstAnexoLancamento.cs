using System;
using System.Collections.Generic;

namespace GruposDB.Models;

public partial class EstAnexoLancamento
{
    public long TenantId { get; set; }

    public long IdAnexo { get; set; }

    public long Lancamentoid { get; set; }

    public string Nomearquivo { get; set; } = null!;

    public byte[]? Arquivo { get; set; }

    public string? Comentario { get; set; }

    public DateTime DtCriacao { get; set; }

    public string? Usuarioid { get; set; }

    public bool IsNfe { get; set; }

    public virtual EstLancamento Lancamento { get; set; } = null!;

    public virtual OssysTenant Tenant { get; set; } = null!;

    public virtual Infrausuario? Usuario { get; set; }
}
