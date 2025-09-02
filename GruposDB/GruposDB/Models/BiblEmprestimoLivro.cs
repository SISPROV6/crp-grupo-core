using System;
using System.Collections.Generic;

namespace GruposDB.Models;

public partial class BiblEmprestimoLivro
{
    public long Id { get; set; }

    public long BiblEmprestimoId { get; set; }

    public long BiblLivroId { get; set; }

    public decimal? Valor { get; set; }

    public virtual BiblEmprestimo BiblEmprestimo { get; set; } = null!;

    public virtual BiblLivro BiblLivro { get; set; } = null!;
}
