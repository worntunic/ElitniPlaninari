using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbori.Mapiranja {
    public class LokacijaDeljenjaLetakaMapiranja : ClassMap<Izbori.Entiteti.LokacijaDeljenjaLetaka>{
        public LokacijaDeljenjaLetakaMapiranja() {
            Table("LokacijaDeljenjaLetaka");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();
            References(x => x.DeljenjeLetaka).Column("IdAkcD").Cascade.None();
            Map(x => x.Lokacija, "Lokacija");
        }
    }
}
