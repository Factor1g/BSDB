using System;
using System.Collections.Generic;

namespace ServiceEquipment.Models;

public partial class Szolgaltatasok
{
    public int Azonosító { get; set; }

    public string? Megnevezes { get; set; }

    public string? Egyseg { get; set; }

    public decimal? DijHuf { get; set; }

    public decimal? AnyagHuf { get; set; }

    public int? AlvallalkozoId { get; set; }

    public DateTime? Datum { get; set; }

    public string? ProjektSzam { get; set; }

    public virtual Alvallalkozok? Alvallalkozo { get; set; }
}
