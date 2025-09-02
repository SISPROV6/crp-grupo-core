using System;
using System.Collections.Generic;

namespace GruposDB.Models;

public partial class BiblEditora
{
    public long Id { get; set; }

    public string TxNome { get; set; } = null!;

    public virtual ICollection<BiblLivro> BiblLivros { get; set; } = new List<BiblLivro>();
}
