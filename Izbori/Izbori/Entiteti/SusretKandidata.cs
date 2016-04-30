using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbori.Entiteti {
    public class SusretKandidata : Akcija{
        public virtual string Lokacija { get; set; }
        public virtual DateTime PlaniranoVreme { get; set; }
    }
}
