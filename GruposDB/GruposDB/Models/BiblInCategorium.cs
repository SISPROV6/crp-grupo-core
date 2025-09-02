using System;
using System.Collections.Generic;

namespace GruposDB.Models;

public partial class BiblInCategorium
{
    public long Id { get; set; }

    public string Label { get; set; } = null!;

    public int? Order { get; set; }

    public bool IsActive { get; set; }

    public virtual ICollection<BiblLivro> BiblLivros { get; set; } = new List<BiblLivro>();
}
