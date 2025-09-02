using System;
using System.Collections.Generic;

namespace GruposDB.Models;

public partial class LocVeiculo
{
    public long Id { get; set; }

    public string Modelo { get; set; } = null!;

    public long MarcaId { get; set; }

    public int Ano { get; set; }

    public string Cor { get; set; } = null!;

    public string Placa { get; set; } = null!;

    public int? Quilometragem { get; set; }

    public decimal ValorDiaria { get; set; }

    public bool? IsDisponivel { get; set; }

    public long? TipoVeiculoId { get; set; }

    public virtual ICollection<LocAluguel> LocAluguels { get; set; } = new List<LocAluguel>();

    public virtual LocMarca Marca { get; set; } = null!;

    public virtual LocTipoVeiculo? TipoVeiculo { get; set; }
}
