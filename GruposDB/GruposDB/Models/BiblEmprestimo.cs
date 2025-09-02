using System;
using System.Collections.Generic;

namespace GruposDB.Models;

public partial class BiblEmprestimo
{
    public long Id { get; set; }

    public string TxProtocolo { get; set; } = null!;

    public long BiblClienteId { get; set; }

    public DateOnly DataEmprestimo { get; set; }

    public DateOnly DataPrevista { get; set; }

    public DateOnly? DataEntrega { get; set; }

    public decimal? Valor { get; set; }

    public decimal? ValorTotal { get; set; }

    public decimal? ValorMulta { get; set; }

    public bool IsReserva { get; set; }

    public virtual BiblCliente BiblCliente { get; set; } = null!;

    public virtual ICollection<BiblEmprestimoLivro> BiblEmprestimoLivros { get; set; } = new List<BiblEmprestimoLivro>();
}
