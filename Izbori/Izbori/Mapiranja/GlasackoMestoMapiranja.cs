using FluentNHibernate.Mapping;
using Izbori.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbori.Mapiranja {
    class GlasackoMestoMapiranja : ClassMap<GlasackoMesto> {
        public GlasackoMestoMapiranja() {
            Table("GlasackoMesto");
            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Naziv, "Naziv");
            Map(x => x.BrojGM, "BrojGM");
            Map(x => x.BrojRegBir, "BrojRegBir");

            HasMany(x => x.RezultatiIzbora).KeyColumn("IDGM").Inverse();
            HasMany(x => x.Primedbe).KeyColumn("IDGM").Inverse();
        }
    }
}
