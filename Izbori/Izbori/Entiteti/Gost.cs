using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbori.Entiteti {
    public class Gost {
        public virtual int IDMiting { get; set; }
        public virtual int ID_GOST { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string Titula { get; set; }
        public virtual string Funkcija { get; set; }
    }
}
