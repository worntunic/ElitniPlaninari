using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbori.Entiteti
{
    public class PitanjaTVDuel
    {
        public virtual int ID { get; set; }
        public virtual TVDuel IDDuela { get; set; }
        public virtual string Tekst { get; set; }
    }
}
