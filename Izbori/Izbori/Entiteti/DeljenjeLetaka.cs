using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbori.Entiteti {
    public class DeljenjeLetaka : Akcija{
        public virtual IList<LokacijaDeljenjaLetaka> LokacijaDeljenjaLetaka { get; set; }

        public DeljenjeLetaka() {
            LokacijaDeljenjaLetaka = new List<LokacijaDeljenjaLetaka>();
        }
    }
}
