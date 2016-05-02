﻿using System;
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

            Id(x => x.IDPK, "IDPK").GeneratedBy.TriggerIdentity();
            
            Map(x => x.ImePK).Column("ImePK");

            References(x => x.IDDuela).Column("IDDuela").Cascade.None();
        }
    }
}