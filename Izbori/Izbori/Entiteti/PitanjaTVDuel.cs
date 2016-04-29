using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbori.Entiteti
{
    class PitanjaTVDuel
    {
        public virtual TVDuel IDDuela { get; set; }
        public virtual string Tekst { get; set; }
    }
}
