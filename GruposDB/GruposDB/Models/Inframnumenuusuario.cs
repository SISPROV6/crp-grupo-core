using System;
using System.Collections.Generic;

namespace GruposDB.Models;

public partial class Inframnumenuusuario
{
    public int TenantId { get; set; }

    public long Id { get; set; }

    public string? Usuarioid { get; set; }

    public long? Menuid { get; set; }

    public bool? IsActive { get; set; }

    public virtual Inframnumenu? Menu { get; set; }

    public virtual Infrausuario? Usuario { get; set; }
}
