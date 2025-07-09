using System;
using System.Collections.Generic;

namespace Model;

public partial class TagulasiTartly
{
    public int Azonosító { get; set; }

    public string? Megnevezes { get; set; }

    public string? Gyarto { get; set; }

    public string? Tipus { get; set; }

    public int? NyomasBar { get; set; }

    public int? MeretL { get; set; }

    public DateTime? Datum { get; set; }

    public decimal? AnyagHuf { get; set; }

    public decimal? DijHuf { get; set; }

    public int? AlvallalkozoId { get; set; }

    public string? ProjektSzam { get; set; }

    public virtual Alvallalkozok? Alvallalkozo { get; set; }
}
