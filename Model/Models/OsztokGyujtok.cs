using System;
using System.Collections.Generic;

namespace Model;

public partial class OsztokGyujtok
{
    public int Azonosító { get; set; }

    public string? Megnevezes { get; set; }

    public string? Korok { get; set; }

    public string? HosszMm { get; set; }

    public string? ProjektSzam { get; set; }

    public DateTime? Datum { get; set; }

    public decimal? AnyagHuf { get; set; }

    public decimal? DijHuf { get; set; }

    public string? Megjegyzes { get; set; }

    public int? AlvallalkozoId { get; set; }
}
