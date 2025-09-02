using System;
using System.Collections.Generic;

namespace GruposDB.Models;

public partial class InfraLogRecupSenha
{
    public int TenantId { get; set; }

    public long Id { get; set; }

    public string? Infrausuarioid { get; set; }

    public string? Guid { get; set; }

    public DateTime? Dtalteracao { get; set; }

    public DateTime? Dtsolicitacao { get; set; }

    public bool? IsEfetivado { get; set; }
}
