using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbori.Entiteti
{
    public class IntervjuNovine
    {        
        public virtual int ID { get; set; }
        public virtual string NazivLista { get; set; }
        public virtual DateTime DatumObjavljivanja { get; set; }
        public virtual DateTime DatumIntervjua { get; set; }
        public virtual IList<NovinariIzNovina> NovinariIzNovina { get; set; }

        public IntervjuNovine() {
            NovinariIzNovina = new List<NovinariIzNovina>();
        }
    }
}
