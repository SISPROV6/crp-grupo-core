using System;
using System.Collections.Generic;

namespace GruposDB.Models;

public partial class Infraauthentication
{
    public int TenantId { get; set; }

    public long Id { get; set; }

    public long? Infrainauthtypeid { get; set; }

    public bool? Is2faenabled { get; set; }

    public long? Infrain2fatypeid { get; set; }
}
