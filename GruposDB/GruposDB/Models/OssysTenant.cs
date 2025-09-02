using System;
using System.Collections.Generic;

namespace GruposDB.Models;

public partial class OssysTenant
{
    public string Name { get; set; } = null!;

    public bool? IsActive { get; set; }

    public long Id { get; set; }

    public virtual ICollection<EstAnexoLancamento> EstAnexoLancamentos { get; set; } = new List<EstAnexoLancamento>();

    public virtual ICollection<EstHistoricoLancamento> EstHistoricoLancamentos { get; set; } = new List<EstHistoricoLancamento>();

    public virtual ICollection<EstHistoricoPreco> EstHistoricoPrecos { get; set; } = new List<EstHistoricoPreco>();

    public virtual ICollection<EstLancamento> EstLancamentos { get; set; } = new List<EstLancamento>();

    public virtual ICollection<EstLogAuditorium> EstLogAuditoria { get; set; } = new List<EstLogAuditorium>();

    public virtual ICollection<EstPessoa> EstPessoas { get; set; } = new List<EstPessoa>();

    public virtual ICollection<EstProduto> EstProdutos { get; set; } = new List<EstProduto>();

    public virtual ICollection<Infrausuario> Infrausuarios { get; set; } = new List<Infrausuario>();
}
