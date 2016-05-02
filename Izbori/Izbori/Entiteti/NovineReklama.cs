using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbori.Entiteti
{
    class NovineReklama : Reklama
    {
        public virtual string Uboji { get; set; }//1 ako je u boji, 0 ako nije
        public virtual string NazivLista { get; set; }
    }
}
