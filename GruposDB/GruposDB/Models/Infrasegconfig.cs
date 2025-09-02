using System;
using System.Collections.Generic;

namespace GruposDB.Models;

public partial class Infrasegconfig
{
    public int TenantId { get; set; }

    public long Id { get; set; }

    public bool? IsLetrasmaiusculas { get; set; }

    public bool? IsNumeros { get; set; }

    public bool? IsCaracteresespeciais { get; set; }

    public int? Qtninatividade { get; set; }

    public int? Qtntrocasenha { get; set; }

    public int? Qtntentativa { get; set; }

    public int? Qtnrepeticao { get; set; }

    public int? Qtnminima { get; set; }

    public bool? IsDropsession { get; set; }

    public int? Level { get; set; }
}
