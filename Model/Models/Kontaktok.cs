using System;
using System.Collections.Generic;

namespace Model;

public partial class Kontaktok
{
    public int Id { get; set; }

    public string Nev { get; set; } = null!;

    public int? Alvallakozo { get; set; }

    public string? Email { get; set; }

    public string? Telefonszam { get; set; }

    public virtual Alvallalkozok? AlvallakozoNavigation { get; set; }
}
