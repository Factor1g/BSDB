using System;
using System.Collections.Generic;

namespace ServiceEquipment.Models;

public partial class Csovezetekek
{
    public int Azonosito { get; set; }

    public string? Varrat { get; set; }

    public string? Feluletkezeles { get; set; }

    public string? Szabvany { get; set; }

    public string? Anyag { get; set; }

    public DateTime? AjanlatDatum { get; set; }

    public int? Dn { get; set; }

    public float? Atmero { get; set; }

    public float? Falvastagag { get; set; }

    public decimal? AnyagEur { get; set; }

    public decimal? AnyagHuf { get; set; }

    public string? Megjegyzes { get; set; }

    public bool? Idomokkal { get; set; }

    public int? AlvallalkozoId { get; set; }

    public string? Gyarto { get; set; }

    public decimal? DijHuf { get; set; }

    public string? ProjektSzam { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual Alvallalkozok? Alvallalkozo { get; set; }
}
