using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbori.Mapiranja {
    public class MitingMapiranja : SubclassMap<Izbori.Entiteti.Miting>{
        public MitingMapiranja() {
            Table("Miting");

            KeyColumn("ID");

            Map(x => x.Lokacija).Column("Lokacija");

            HasMany(x => x.Gosti).KeyColumn("IDMiting").LazyLoad().Cascade.All().Inverse();
        }
    }
}
