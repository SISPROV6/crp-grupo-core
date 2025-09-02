using System;
using System.Collections.Generic;

namespace GruposDB.Models;

public partial class Inframnumenu
{
    public int TenantId { get; set; }

    public long Id { get; set; }

    public string? Unicoid { get; set; }

    public string? Label { get; set; }

    public string? LabelEnglish { get; set; }

    public string? LabelSpanish { get; set; }

    public string? Descricao { get; set; }

    public string? DescricaoEnglish { get; set; }

    public string? DescricaoSpanish { get; set; }

    public DateTime? Datacreate { get; set; }

    public int? Order { get; set; }

    public string? Classicon { get; set; }

    public bool? Isactive { get; set; }

    public string? Urldashboard { get; set; }

    public string? Url { get; set; }

    public string? TxModuloCod { get; set; }

    public virtual ICollection<Inframnumenuusuario> Inframnumenuusuarios { get; set; } = new List<Inframnumenuusuario>();
}
