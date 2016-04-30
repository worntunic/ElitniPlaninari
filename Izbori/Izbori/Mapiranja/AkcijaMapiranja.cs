using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbori.Mapiranja {
    public class AkcijaMapiranja : ClassMap<Izbori.Entiteti.Akcija> {
        public AkcijaMapiranja() {
            Table("Akcija");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.NazivAkcije, "NazivAkcije");
            Map(x => x.Grad, "Grad");

            //TODO: Kada se dodaju entiteti veza, dodati njihova mapiranja
        }
    }
}
