using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbori.Entiteti
{
    public abstract class PojavljivanjaPK
    {
        public virtual int ID { get; set; }
        public virtual int DummyColumn { get; set; }
    }
}