using System;
using System.Collections.Generic;

namespace GruposDB.Models;

public partial class LocFuncionario
{
    public long Id { get; set; }

    public string Nome { get; set; } = null!;

    public string Cpf { get; set; } = null!;

    public string Telefone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public virtual ICollection<LocAluguel> LocAluguels { get; set; } = new List<LocAluguel>();
}
