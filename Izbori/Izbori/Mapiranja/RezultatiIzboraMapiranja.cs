using FluentNHibernate.Mapping;
using Izbori.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbori.Mapiranja {
    class RezultatiIzboraMapiranja : ClassMap<RezultatiIzbora>{
        public RezultatiIzboraMapiranja() {
            Table("RezultatiIzbora");
            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.BrKruga, "BrKruga");
            Map(x => x.BrBiraca, "BrBiraca");
            Map(x => x.ProcenatZaKandidata, "ProcenatZaKandidata");
            References(x => x.GlasackoMesto).Column("IDGM").LazyLoad();
        }
    }
}
