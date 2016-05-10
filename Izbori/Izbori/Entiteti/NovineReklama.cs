using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbori.Entiteti
{
    public class NovineReklama : Reklama
    {
        public virtual int Uboji { get; set; }//1 ako je u boji, 0 ako nije
        public virtual string NazivLista { get; set; }
    }
}
