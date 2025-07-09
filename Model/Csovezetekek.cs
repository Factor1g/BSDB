using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public partial class Csovezetekek : IEntity
    {
        public int Id { get => this.Azonosito; }
        public string Name { get => this.Dn.ToString(); }
        public DateTime? Date { get => this.AjanlatDatum; }        
    }
}
