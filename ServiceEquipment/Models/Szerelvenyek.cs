using System;
using System.Collections.Generic;

namespace ServiceEquipment.Models;

public partial class Szerelvenyek
{
    public int Azonosító { get; set; }

    public string? Megnevezes { get; set; }

    public int? Atmero { get; set; }

    public string? Anyag { get; set; }

    public int? Nyomas { get; set; }

    public string? Tipus { get; set; }

    public string? Gyarto { get; set; }

    public DateTime? Datum { get; set; }

    public int? AlvallalkozoId { get; set; }

    public decimal? AnyagHuf { get; set; }

    public decimal? DijHuf { get; set; }

    public string? Csatlakozas { get; set; }

    public string? Megjegyzes { get; set; }

    public int? Kvs { get; set; }

    public int? TerfogataramLh { get; set; }

    public string? ProjektSzam { get; set; }

    public virtual Alvallalkozok? Alvallalkozo { get; set; }
}
