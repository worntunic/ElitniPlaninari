using FluentNHibernate.Mapping;
using Izbori.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbori.Mapiranja {
    public class PrimedbeMapiranja : ClassMap<Primedbe>{
        public PrimedbeMapiranja() {
            Table("Primedbe");
            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            References(x => x.Aktivista).Column("IDAkt");
            References(x => x.GlasackoMesto).Column("IDGM");

            Map(x => x.TekstPrim, "TekstPrim");
        }
    }
}
