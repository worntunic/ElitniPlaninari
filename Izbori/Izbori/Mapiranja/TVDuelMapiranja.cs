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

            HasMany(x => x.Pitanja).KeyColumn("Pitanja").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.ProtivKandidati).KeyColumn("ProtivKandidati").LazyLoad().Cascade.All().Inverse();
        }
    }
}
