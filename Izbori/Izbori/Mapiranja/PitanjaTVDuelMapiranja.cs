﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Izbori.Entiteti;
using FluentNHibernate.Mapping;

namespace Izbori.Mapiranja
{
    public class PitanjaTVDuelMapiranja : ClassMap<PitanjaTVDuel>
    {
        public PitanjaTVDuelMapiranja()
        {
            Table("PitanjaTVDuel");

            Id(x => x.ID, "IDPitanja").GeneratedBy.TriggerIdentity();

            Map(x => x.Tekst).Column("Tekst");

            References(x => x.IDDuela).Column("IDDuela").Cascade.None();
        }
    }
}
