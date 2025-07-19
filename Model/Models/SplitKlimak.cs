using System;
using System.Collections.Generic;

namespace Model;

public partial class SplitKlimak
{
    public int Id { get; set; }

    public string? Gyarto { get; set; }

    public string? Cikkszam { get; set; }

    public string? Megnevezes { get; set; }

    public float? TeljesitmenyKW { get; set; }

    public decimal? AnyagHuf { get; set; }

    public DateTime? Datum { get; set; }

    public int? AlvallalkozoId { get; set; }

    public decimal? AnyagEur { get; set; }

    public string? ProjektSzam { get; set; }

    public decimal? DijHuf { get; set; }

    public string? Megjegyzes { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual Alvallalkozok? Alvallalkozo { get; set; }

    public virtual Projektek? ProjektSzamNavigation { get; set; }
}
