using System;
using System.Collections.Generic;

namespace GruposDB.Models;

public partial class Infrausuariolog1
{
    public int TenantId { get; set; }

    public long Id { get; set; }

    public string? Infrausuarioid { get; set; }

    public DateTime? Datetime { get; set; }
}
