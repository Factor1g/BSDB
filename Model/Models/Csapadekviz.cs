using System;
using System.Collections.Generic;

namespace Model;

public partial class Csapadekviz
{
    public int Azonosító { get; set; }

    public string? Megnevezes { get; set; }

    public string? Meret { get; set; }

    public string? Gyarto { get; set; }

    public string? Anyag { get; set; }

    public string? Megjegyzes { get; set; }

    public decimal? AnyagHuf { get; set; }

    public int? AlvallalkozoId { get; set; }

    public DateTime? Datum { get; set; }

    public string? ProjektSzam { get; set; }

    public virtual Alvallalkozok? Alvallalkozo { get; set; }

    public virtual Projektek? ProjektSzamNavigation { get; set; }
}
