using System;
using System.Collections.Generic;

namespace GruposDB.Models;

public partial class Infraemailcfg
{
    public int TenantId { get; set; }

    public long Id { get; set; }

    public string? Smtpserver { get; set; }

    public int? Smtpport { get; set; }

    public int? Timeout { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? Nomeremet { get; set; }

    public string? Emailadress { get; set; }

    public bool? IsSsl { get; set; }

    public bool? IsTls { get; set; }

    public bool? IsAuthenticated { get; set; }

    public bool? Confirmleit { get; set; }

    public bool? Confirmentreg { get; set; }

    public string? Imapserver { get; set; }

    public int? Imapport { get; set; }

    public string? Infraestabid { get; set; }

    public string? PasswordAng { get; set; }

    public string? Urlservidor { get; set; }
}
