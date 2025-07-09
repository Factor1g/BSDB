using System;
using System.Collections.Generic;

namespace Model;

public partial class Szivattyuk
{
    public int Azonosító { get; set; }

    public string? Tipus { get; set; }

    public string? Cikkszam { get; set; }

    public string? Gyarto { get; set; }

    public float? TerfogataramM3h { get; set; }

    public float? SzallitomagassagM { get; set; }

    public float? TeljesitmenyKW { get; set; }

    public float? NyomasBar { get; set; }

    public DateTime? Datum { get; set; }

    public int? AlvallalkozoId { get; set; }

    public decimal? AnyagHuf { get; set; }

    public decimal? DijHuf { get; set; }

    public string? Megjegyzes { get; set; }

    public string? ProjektSzam { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual Alvallalkozok? Alvallalkozo { get; set; }
}
