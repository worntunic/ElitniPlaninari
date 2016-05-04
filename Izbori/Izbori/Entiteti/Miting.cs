using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbori.Entiteti {
    public class Miting : Akcija {
        public virtual string Lokacija { get; set; }
        public virtual IList<Gost> Gosti { get; set; }

        public Miting() {
            Gosti = new List<Gost>();
        }
    }
}
