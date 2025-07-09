using System;
using System.Collections.Generic;

namespace ServiceEquipment.Models;

public partial class Legcsatornak
{
    public int Azonosító { get; set; }

    public string? Megnevezes { get; set; }

    public string? Cikkszam { get; set; }

    public string? MeretMm { get; set; }

    public string? Egyseg { get; set; }

    public decimal? AnyagHuf { get; set; }

    public decimal? DijHuf { get; set; }

    public DateTime? Datum { get; set; }

    public int? AlvallalkozoId { get; set; }

    public string? Anyagminoseg { get; set; }

    public string? Gyarto { get; set; }

    public string? ProjektSzam { get; set; }

    public virtual Alvallalkozok? Alvallalkozo { get; set; }
}
