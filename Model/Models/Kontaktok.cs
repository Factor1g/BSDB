using System;
using System.Collections.Generic;

namespace Model;

public partial class Kontaktok
{
    public int Id { get; set; }

    public string Nev { get; set; } = null!;

    public int? AlvallakozoId { get; set; }

    public string? Email { get; set; }

    public string? Telefonszam { get; set; }

    public virtual Alvallalkozok? Alvallakozo { get; set; }
}
