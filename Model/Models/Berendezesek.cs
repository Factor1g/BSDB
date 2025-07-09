using System;
using System.Collections.Generic;

namespace Model;

public partial class Berendezesek
{
    public int Azonosító { get; set; }

    public string? Berendezes { get; set; }

    public string? Termek { get; set; }

    public string? Gyarto { get; set; }

    public DateTime? Datum { get; set; }

    public decimal? AnyagHuf { get; set; }

    public decimal? DijHuf { get; set; }

    public int? AlvallalkozoId { get; set; }

    public string? ProjektSzam { get; set; }

    public virtual Alvallalkozok? Alvallalkozo { get; set; }
}
