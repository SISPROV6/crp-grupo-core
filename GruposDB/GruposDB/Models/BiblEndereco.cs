using System;
using System.Collections.Generic;

namespace GruposDB.Models;

public partial class BiblEndereco
{
    public long Id { get; set; }

    public string Rua { get; set; } = null!;

    public string Nro { get; set; } = null!;

    public string Bairro { get; set; } = null!;

    public string Cidade { get; set; } = null!;

    public string Uf { get; set; } = null!;

    public string? Regiao { get; set; }

    public long BiblInTipoEndereco { get; set; }

    public virtual ICollection<BiblAutor> BiblAutors { get; set; } = new List<BiblAutor>();

    public virtual ICollection<BiblCliente> BiblClientes { get; set; } = new List<BiblCliente>();

    public virtual BiblInTipoEndereco BiblInTipoEnderecoNavigation { get; set; } = null!;
}
