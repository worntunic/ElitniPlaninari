using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbori.Entiteti
{
    public abstract class Reklama
    {
        public virtual int ID { get; set; }
        public virtual int CenaZakupa { get; set; }
        public virtual DateTime DatumZakupa { get; set; }
        public virtual int TrajanjeZakupa { get; set; } //Ako se ne varam, rekli smo da je trajanje u danima
    }
}
