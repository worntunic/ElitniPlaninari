using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbori.Entiteti {
    public class Primedbe {
        public virtual int ID { get; set; }
        public virtual Aktivista Aktivista { get; set; }
        public virtual GlasackoMesto GlasackoMesto { get; set; }
        public virtual string TekstPrim { get; set; }
    }
}
