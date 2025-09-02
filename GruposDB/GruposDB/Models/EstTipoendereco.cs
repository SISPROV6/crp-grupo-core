using System;
using System.Collections.Generic;

namespace GruposDB.Models;

public partial class EstTipoendereco
{
    public string CdTipoendereco { get; set; } = null!;

    public string TxTipoendereco { get; set; } = null!;

    public virtual ICollection<EstEndereco> EstEnderecos { get; set; } = new List<EstEndereco>();
}
