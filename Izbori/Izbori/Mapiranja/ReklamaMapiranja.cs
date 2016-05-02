using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Izbori.Entiteti;
using FluentNHibernate.Mapping;

namespace Izbori.Mapiranja
{
    class ReklamaMapiranja : ClassMap<Reklama>
    {
        public ReklamaMapiranja()
        {
            Table("Reklama");

            //DiscriminateSubClassesOnColumn("TIP");
            
            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity().UnsavedValue(-1);
            
            Map(x => x.CenaZakupa).Column("CenaZakupa");
            Map(x => x.DatumZakupa).Column("DatumZakupa");
            Map(x => x.TrajanjeZakupa).Column("TrajanjeZakupa");


        }
    }
}
