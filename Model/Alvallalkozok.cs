using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public partial class Alvallalkozok : IEntity
    {
        public string Megnevezes => this.Nev;

        public DateTime? Date => this.Date;
    }
}
