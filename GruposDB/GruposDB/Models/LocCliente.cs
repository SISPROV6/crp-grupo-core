using System;
using System.Collections.Generic;

namespace GruposDB.Models;

public partial class LocCliente
{
    public long Id { get; set; }

    public string Nome { get; set; } = null!;

    public string Rg { get; set; } = null!;

    public string Cpf { get; set; } = null!;

    public string Telefone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public bool IsEspecial { get; set; }

    public virtual ICollection<LocAluguel> LocAluguels { get; set; } = new List<LocAluguel>();

    public virtual ICollection<LocEnderecoCliente> LocEnderecoClientes { get; set; } = new List<LocEnderecoCliente>();
}
