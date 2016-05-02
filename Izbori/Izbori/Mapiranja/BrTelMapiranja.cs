using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Izbori.Entiteti;

namespace Izbori.Mapiranja
{
    public class BrTelMapiranja : ClassMap<BrTel>
    {
        public BrTelMapiranja()
        {
            Table("BRTELAKTIVISTA");

            Id(x => x.IDBr, "IDBR").GeneratedBy.TriggerIdentity();
            References(x => x.Aktivista).Column("IDAkt").Cascade.None();
            Map(x => x.BrojTel, "BrTel");
        }
    }
}
