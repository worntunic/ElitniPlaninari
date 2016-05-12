using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbori.Mapiranja {
    public class DeljenjeLetakaMapiranja : SubclassMap<Izbori.Entiteti.DeljenjeLetaka> {
        
        public DeljenjeLetakaMapiranja() {
            Table("DeljenjeLetaka");

            KeyColumn("ID");

            HasMany(x => x.LokacijaDeljenjaLetaka).KeyColumn("ID").LazyLoad().Cascade.All().Inverse();
        }
    }
}
