using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Izbori.Entiteti;
using FluentNHibernate.Mapping;

namespace Izbori.Mapiranja
{
    class TVDuelMapiranja : SubclassMap<TVDuel>
    {
        public TVDuelMapiranja()
        {
            Table("TVDuel");
            
            KeyColumn("IDTVRG");

            Map(x => x.IDTVRG).Column("IDTVRG");
        }
    }
}
