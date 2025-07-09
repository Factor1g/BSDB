using System;
using System.Collections.Generic;

namespace ServiceEquipment.Models;

public partial class Kontaktok
{
    public int Id { get; set; }

    public string Nev { get; set; } = null!;

    public int? Alvallakozo { get; set; }

    public string? Email { get; set; }

    public string? Telefonszam { get; set; }

    public virtual Alvallalkozok? AlvallakozoNavigation { get; set; }
}
