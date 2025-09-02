using System;
using System.Collections.Generic;

namespace GruposDB.Models;

public partial class EstContato
{
    public long Id { get; set; }

    public string PessoaId { get; set; } = null!;

    public string? TxApelidocontato { get; set; }

    public string? TxEmail { get; set; }

    public string? TxTelefonefixo { get; set; }

    public string? TxCelular { get; set; }

    public string? TxRamal { get; set; }

    public virtual EstPessoa Pessoa { get; set; } = null!;
}
