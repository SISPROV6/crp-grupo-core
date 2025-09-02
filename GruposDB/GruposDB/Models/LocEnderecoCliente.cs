using System;
using System.Collections.Generic;

namespace GruposDB.Models;

public partial class LocEnderecoCliente
{
    public long Id { get; set; }

    public string Logradouro { get; set; } = null!;

    public int Numero { get; set; }

    public string Bairro { get; set; } = null!;

    public string? Complemento { get; set; }

    public string Cidade { get; set; } = null!;

    public string EstadoUf { get; set; } = null!;

    public string Cep { get; set; } = null!;

    public long LocClienteId { get; set; }

    public virtual LocCliente LocCliente { get; set; } = null!;
}
