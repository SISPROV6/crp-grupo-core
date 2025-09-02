using System;
using System.Collections.Generic;

namespace GruposDB.Models;

public partial class BiblCliente
{
    public long Id { get; set; }

    public string TxNome { get; set; } = null!;

    public string? TxCpf { get; set; }

    public long BiblInTipoClienteId { get; set; }

    public long? BiblEnderecoId { get; set; }

    public virtual ICollection<BiblEmprestimo> BiblEmprestimos { get; set; } = new List<BiblEmprestimo>();

    public virtual BiblEndereco? BiblEndereco { get; set; }

    public virtual BiblInTipoCliente BiblInTipoCliente { get; set; } = null!;
}
