using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Izbori.Entiteti;
using FluentNHibernate.Mapping;

namespace Izbori.Mapiranja
{
    class NovinariIzNovinaMapiranja : SubclassMap<NovinariIzNovina>
    {
        public NovinariIzNovinaMapiranja()
        {
            Table("NovinariIzNovina");
            Map(x => x.ImeNovinara).Column("ImeNovinara");            
        }
    }
}
