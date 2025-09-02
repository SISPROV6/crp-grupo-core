using System;
using System.Collections.Generic;

namespace GruposDB.Models;

public partial class Infrausuariosenhaslog
{
    public int TenantId { get; set; }

    public long Id { get; set; }

    public string? Senha { get; set; }

    public string? Infrausuarioid { get; set; }

    public DateTime? Datetime { get; set; }

    public bool? IsEffective { get; set; }

    public virtual Infrausuario? Infrausuario { get; set; }
}
