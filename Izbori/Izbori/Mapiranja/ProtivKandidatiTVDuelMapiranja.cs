using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Izbori.Entiteti;
using FluentNHibernate.Mapping;

namespace Izbori.Mapiranja
{
    class ProtivKandidatiTVDuelMapiranja : ClassMap<ProtivKandidatiTVDuel>
    {
        public ProtivKandidatiTVDuelMapiranja()
        {
            Table("ProtivKandidatiTVDuel");
            CompositeId(x => x.Id)
                .KeyReference(x => x.IDDuela, "IDDuela")
                .KeyReference(x => x.ImePK, "ImePK");
            Map(x => x.IDDuela).Column("IDDuela");
            Map(x => x.ImePK).Column("ImePK");
        }
    }
}
