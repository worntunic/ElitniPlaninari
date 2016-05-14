/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Izbori.Entiteti;
using FluentNHibernate.Mapping;

namespace Izbori.Mapiranja
{
    public class TVDuelMapiranja : SubclassMap<TVDuel>
    {
        public TVDuelMapiranja()
        {
            Table("TVDuel");
            
            KeyColumn("IDTVRG");

            HasMany(x => x.Pitanja).KeyColumn("IDDuela").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.ProtivKandidati).KeyColumn("IDPK").LazyLoad().Cascade.All().Inverse();
        }
    }
}*/
