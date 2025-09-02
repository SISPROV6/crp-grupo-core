using System;
using System.Collections.Generic;

namespace GruposDB.Models;

public partial class InfrausuarioImg
{
    public int TenantId { get; set; }

    public long Id { get; set; }

    public byte[]? Imagem { get; set; }

    public string? Filename { get; set; }

    public DateTime? Datacriacao { get; set; }

    public bool? IsActive { get; set; }

    public string? Usuarioid { get; set; }
}
