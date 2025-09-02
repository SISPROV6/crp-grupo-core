using System;
using System.Collections.Generic;

namespace GruposDB.Models;

public partial class Infraestabelecimento
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Nomeexibicao { get; set; }

    public string? Codigo { get; set; }

    public string? Razaosocial { get; set; }

    public string? Nomefantasia { get; set; }

    public string? Cnpj { get; set; }

    public bool? IsMatriz { get; set; }

    public bool? IsActive { get; set; }

    public string? Empresaid { get; set; }

    public int? Idiomaid { get; set; }

    public string? Avisoinicial { get; set; }

    public virtual Infraempresa? Empresa { get; set; }

    public virtual ICollection<EstLancamento> EstLancamentos { get; set; } = new List<EstLancamento>();
}
