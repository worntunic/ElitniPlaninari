using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Izbori.Entiteti;

namespace Izbori.Entiteti
{
    public class BrTel
    {
        public virtual int IDBr { get; set; }
        public virtual Aktivista Aktivista { get; set; }
        public virtual string BrojTel { get; set; }
    }
}
