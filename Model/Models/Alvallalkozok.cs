using System;
using System.Collections.Generic;

namespace Model;

public partial class Alvallalkozok
{
    public int Id { get; set; }

    public string Nev { get; set; } = null!;

    public string? Terulet { get; set; }

    public virtual ICollection<Belimo> Belimos { get; set; } = new List<Belimo>();

    public virtual ICollection<Berendezesek> Berendezeseks { get; set; } = new List<Berendezesek>();

    public virtual ICollection<Csapadekviz> Csapadekvizs { get; set; } = new List<Csapadekviz>();

    public virtual ICollection<Csovezetekek> Csovezetekeks { get; set; } = new List<Csovezetekek>();

    public virtual ICollection<Kontaktok> Kontaktoks { get; set; } = new List<Kontaktok>();

    public virtual ICollection<Legcsatornak> Legcsatornaks { get; set; } = new List<Legcsatornak>();

    public virtual ICollection<SplitKlimak> SplitKlimaks { get; set; } = new List<SplitKlimak>();

    public virtual ICollection<Szerelvenyek> Szerelvenyeks { get; set; } = new List<Szerelvenyek>();

    public virtual ICollection<Szigetele> Szigeteles { get; set; } = new List<Szigetele>();

    public virtual ICollection<Szivattyuk> Szivattyuks { get; set; } = new List<Szivattyuk>();

    public virtual ICollection<Szolgaltatasok> Szolgaltatasoks { get; set; } = new List<Szolgaltatasok>();

    public virtual ICollection<TagulasiTartly> TagulasiTartlies { get; set; } = new List<TagulasiTartly>();

    public virtual ICollection<Vizlagyitok> Vizlagyitoks { get; set; } = new List<Vizlagyitok>();
}
