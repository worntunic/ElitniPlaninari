using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbori.Entiteti
{
    class NovineReklama : Reklama
    {
        public virtual string Uboji { get; set; }
        public virtual string NazivLista { get; set; }
    }
}
