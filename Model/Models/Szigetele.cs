using System;
using System.Collections.Generic;

namespace Model;

public partial class Szigetele
{
    public int Azonosító { get; set; }

    public string? Mező1 { get; set; }

    public string? Szigeteles { get; set; }

    public int? KulsoAtmero { get; set; }

    public float? Falvastagsag { get; set; }

    public DateTime? Datum { get; set; }

    public int? AlvallalkozoId { get; set; }

    public decimal? AnyagHuf { get; set; }

    public decimal? DijHuf { get; set; }

    public int? CsoDn { get; set; }

    public string? Egyseg { get; set; }

    public string? ProjektSzam { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual Alvallalkozok? Alvallalkozo { get; set; }
}
