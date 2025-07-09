using System;
using System.Collections.Generic;

namespace Model;

public partial class Szaniter
{
    public int Azonosító { get; set; }

    public string? Megnevezes { get; set; }

    public DateTime? Datum { get; set; }

    public int? AlvallalkozoId { get; set; }

    public decimal? AnyagHuf { get; set; }

    public decimal? DijHuf { get; set; }

    public string? ProjektSzam { get; set; }
}
