using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbori.Entiteti
{
    class ProtivKandidatiTVDuel
    {
        public virtual TVDuel IDDuela { get; set; }
        public virtual string ImePK { get; set; } //ProtivKandidata
        public virtual int IDPK { get; set; }//protivkandidata
    }
}
