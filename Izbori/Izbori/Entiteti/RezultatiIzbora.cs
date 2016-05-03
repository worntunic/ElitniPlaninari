using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbori.Entiteti {
    public class RezultatiIzbora {
        public virtual int ID { get; set; }
        public virtual int BrKruga { get; set; }
        public virtual int BrBiraca { get; set; }
        public virtual int ProcenatZaKandidata { get; set; }
        public virtual GlasackoMesto GlasackoMesto { get; set; }
    }
}
