using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbori.Entiteti
{
    class TVRadioReklama : Reklama
    {
        public virtual int BrojPonavljanja { get; set; }
        public virtual int Trajanje { get; set; }//u sekundama
        public virtual string NazivStanice { get; set; }
    }
}
