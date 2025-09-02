using System;
using System.Collections.Generic;

namespace GruposDB.Models;

public partial class BiblAutor
{
    public long Id { get; set; }

    public string TxNome { get; set; } = null!;

    public long? BiblEnderecoId { get; set; }

    public virtual BiblEndereco? BiblEndereco { get; set; }

    public virtual ICollection<BiblLivro> BiblLivros { get; set; } = new List<BiblLivro>();
}
