using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Izbori.Entiteti;
using FluentNHibernate.Mapping;

namespace Izbori.Mapiranja
{
    public class NovinariIzNovinaMapiranja : ClassMap<NovinariIzNovina>
    {
        public NovinariIzNovinaMapiranja()
        {
            Table("NovinariIzNovina");

            Id(x => x.IDNovinara, "IDNovinara").GeneratedBy.TriggerIdentity();

            Map(x => x.ImeNovinara).Column("ImeNovinara");
            References(x => x.IDIntervjua).Column("IDIntervjua").Cascade.None();
        }
    }
}
