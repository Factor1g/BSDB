using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    partial class Belimo : IEntity
    {
        //public string Name => this.Megnevezes;

        public DateTime? Date => this.Datum;
    }
}
