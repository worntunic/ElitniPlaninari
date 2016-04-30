using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbori.Entiteti {
    public class MitingZatvoreniP : Miting{
        public virtual string NazivIznajmljivaca { get; set; }
        public virtual float Cena { get; set; }
    }
}
