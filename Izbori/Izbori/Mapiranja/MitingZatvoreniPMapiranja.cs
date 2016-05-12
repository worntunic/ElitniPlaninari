using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbori.Mapiranja {
    public class MitingZatvoreniPMapiranja : SubclassMap<Izbori.Entiteti.MitingZatvoreniP>{
        public MitingZatvoreniPMapiranja() {
            Table("MitingZatvoreniP");

            KeyColumn("IDMiting");

            Map(x => x.NazivIznajmljivaca).Column("Iznajmljivac");
            Map(x => x.Cena).Column("Cena");
        }
    }
}
