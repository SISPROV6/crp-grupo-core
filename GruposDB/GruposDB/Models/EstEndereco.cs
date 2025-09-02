using System;
using System.Collections.Generic;

namespace GruposDB.Models;

public partial class EstEndereco
{
    public string IdEndereco { get; set; } = null!;

    public string? PessoaId { get; set; }

    public string Logradouro { get; set; } = null!;

    public int? Numero { get; set; }

    public string? Complemento { get; set; }

    public string Bairro { get; set; } = null!;

    public string Cidade { get; set; } = null!;

    public string Uf { get; set; } = null!;

    public string Cep { get; set; } = null!;

    public string? TipoenderecoCd { get; set; }

    public bool IsPrincipal { get; set; }

    public virtual EstPessoa? Pessoa { get; set; }

    public virtual EstTipoendereco? TipoenderecoCdNavigation { get; set; }

    public virtual EstUf UfNavigation { get; set; } = null!;
}
