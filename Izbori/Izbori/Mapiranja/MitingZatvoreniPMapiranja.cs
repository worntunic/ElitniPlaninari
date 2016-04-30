using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbori.Mapiranja {
    class MitingZatvoreniPMapiranja : SubclassMap<Izbori.Entiteti.MitingZatvoreniP>{
        public MitingZatvoreniPMapiranja() {
            Table("MitingZatvoreniP");

            KeyColumn("ID");

            Map(x => x.NazivIznajmljivaca).Column("NazivIznajmljivaca");
            Map(x => x.Cena).Column("Cena");
        }
    }
}
