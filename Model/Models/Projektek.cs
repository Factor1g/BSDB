using System;
using System.Collections.Generic;

namespace Model;

public partial class Projektek
{
    public string? Megnevezes { get; set; }

    public string? Beruhazo { get; set; }

    public string? Tipus { get; set; }

    public string? Helyszin { get; set; }

    public string ProjektSzam { get; set; } = null!;

    public virtual ICollection<Csapadekviz> Csapadekvizs { get; set; } = new List<Csapadekviz>();
}
