using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbori.Entiteti {
    public class GlasackoMesto {
        public virtual int ID { get; set; }
        public virtual string Naziv { get; set; }
        public virtual int BrojGM { get; set; }
        public virtual int BrojRegBir { get; set; }
        public virtual IList<RezultatiIzbora> RezultatiIzbora { get; set; }
        public virtual IList<Primedbe> Primedbe { get; set; }
        public virtual IList<Aktivista> Posmatraci { get; set; }
        public GlasackoMesto() {
            RezultatiIzbora = new List<RezultatiIzbora>();
            Primedbe = new List<Primedbe>();
            Posmatraci = new List<Aktivista>();
        }
    }
}
