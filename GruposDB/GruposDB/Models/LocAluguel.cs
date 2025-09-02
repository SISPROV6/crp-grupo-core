using System;
using System.Collections.Generic;

namespace GruposDB.Models;

public partial class LocAluguel
{
    public long Id { get; set; }

    public long LocClienteId { get; set; }

    public long LocFuncionarioId { get; set; }

    public long LocVeiculoId { get; set; }

    public DateOnly DtRetirada { get; set; }

    public DateOnly DtEntregaPrevista { get; set; }

    public DateOnly DtEntregaEfetiva { get; set; }

    public decimal? ValorPrevisto { get; set; }

    public decimal ValorFinal { get; set; }

    public decimal? ValorMulta { get; set; }

    public decimal? ValorDesconto { get; set; }

    public bool? IsEncerrado { get; set; }

    public virtual LocCliente LocCliente { get; set; } = null!;

    public virtual LocFuncionario LocFuncionario { get; set; } = null!;

    public virtual LocVeiculo LocVeiculo { get; set; } = null!;
}
