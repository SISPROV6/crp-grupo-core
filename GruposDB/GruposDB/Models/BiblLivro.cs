using System;
using System.Collections.Generic;

namespace GruposDB.Models;

public partial class BiblLivro
{
    public long Id { get; set; }

    public string TxTitulo { get; set; } = null!;

    public long BiblAutorId { get; set; }

    public long BiblEditoraId { get; set; }

    public long BiblInCategoriaId { get; set; }

    public string? Isbn { get; set; }

    public string? LocalPublicacao { get; set; }

    public int QtdEstoque { get; set; }

    public virtual BiblAutor BiblAutor { get; set; } = null!;

    public virtual BiblEditora BiblEditora { get; set; } = null!;

    public virtual ICollection<BiblEmprestimoLivro> BiblEmprestimoLivros { get; set; } = new List<BiblEmprestimoLivro>();

    public virtual BiblInCategorium BiblInCategoria { get; set; } = null!;
}
