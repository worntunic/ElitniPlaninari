using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbori.Entiteti {
    public class LokacijaDeljenjaLetaka {
        public virtual int ID { get; set; }
        public virtual DeljenjeLetaka DeljenjeLetaka { get; set; }
        public virtual string Lokacija { get; set; }
    }
}
