using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbori.Entiteti
{
    class TVDuel : TVRadioGost
    {
        public virtual TVRadioGost IDTVRG { get; set; }     
    }
}
