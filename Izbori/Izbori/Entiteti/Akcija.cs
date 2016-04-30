using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbori.Entiteti
{
    public class Akcija
    {
        public virtual int ID { get; protected set; }
        public virtual string NazivAkcije { get; set; }
        public virtual string Grad { get; set; }

        //TODO: Treba dodati entitete veza
    }
}
