using System;
using System.Collections.Generic;

namespace GruposDB.Models;

public partial class Infrausuario
{
    public long? TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Usuario { get; set; }

    public string? Senha { get; set; }

    public string? Nome { get; set; }

    public string? Email { get; set; }

    public string? Telefone { get; set; }

    public string? Cargo { get; set; }

    public DateTime? Datacriacao { get; set; }

    public DateTime? Dataultimoacesso { get; set; }

    public bool? IsBloqueado { get; set; }

    public bool? IsActive { get; set; }

    public int? Useroutsystemsid { get; set; }

    public int? Idiomaid { get; set; }

    public long? Infraconfigldap { get; set; }

    public string? Lastlogestabid { get; set; }

    public string? Lastlogsprint { get; set; }

    public bool? Readlastsprint { get; set; }

    public bool? Usaerp { get; set; }

    public bool? ForcePswchange { get; set; }

    public bool? Usachat { get; set; }

    public string? Senhahash512 { get; set; }

    public string? TxCpf { get; set; }

    public DateTime? DtHoraValidadeLogin { get; set; }

    public bool? IsExterno { get; set; }

    public virtual ICollection<EstAnexoLancamento> EstAnexoLancamentos { get; set; } = new List<EstAnexoLancamento>();

    public virtual ICollection<EstHistoricoLancamento> EstHistoricoLancamentos { get; set; } = new List<EstHistoricoLancamento>();

    public virtual ICollection<EstLogAuditorium> EstLogAuditoria { get; set; } = new List<EstLogAuditorium>();

    public virtual ICollection<Inframnumenuusuario> Inframnumenuusuarios { get; set; } = new List<Inframnumenuusuario>();

    public virtual ICollection<Infrausuariosenhaslog> Infrausuariosenhaslogs { get; set; } = new List<Infrausuariosenhaslog>();

    public virtual OssysTenant? Tenant { get; set; }
}
