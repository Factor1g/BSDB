using System;
using System.Collections.Generic;

namespace Model;

public partial class Vizlagyitok
{
    public int Id { get; set; }

    public string? Megnevezes { get; set; }

    public string? Tipus { get; set; }

    public float? KapacitasM3H { get; set; }

    public DateTime? Datum { get; set; }

    public decimal? AnyagHuf { get; set; }

    public decimal? DijHuf { get; set; }

    public int? AlvallalkozoId { get; set; }

    public string? Gyarto { get; set; }

    public string? ProjektSzam { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual Alvallalkozok? Alvallalkozo { get; set; }

    public virtual Projektek? ProjektSzamNavigation { get; set; }
}
