using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbori.Entiteti
{
    public class ProtivKandidatiTVDuel
    {
        public virtual int ID { get; set; }//protivkandidata
        public virtual TVDuel IDDuela { get; set; }
        public virtual string ImePK { get; set; } //ProtivKandidata
    }
}
