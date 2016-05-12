using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Izbori.Entiteti;
using FluentNHibernate.Mapping;

namespace Izbori.Mapiranja
{
    public class ReklamaMapiranja : ClassMap<Reklama>
    {
        public ReklamaMapiranja()
        {
            Table("Reklama");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();
            
            Map(x => x.CenaZakupa).Column("CenaZakupa");
            Map(x => x.DatumZakupa).Column("DatumZakupa");
            Map(x => x.TrajanjeZakupa).Column("TrajanjeZakupa");
        }
    }
}
