using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Izbori.Entiteti;
using FluentNHibernate.Mapping;

namespace Izbori.Mapiranja
{
    public class IntervjuNovineMapiranja : ClassMap<IntervjuNovine>
    {
        public IntervjuNovineMapiranja()
        {
            Table("IntervjuNovine");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.NazivLista).Column("NazivLista");
            Map(x => x.DatumObjavljivanja).Column("DatumObjavljivanja");
            Map(x => x.DatumIntervjua).Column("DatumIntervjua");

            HasMany(x => x.NovinariIzNovina).KeyColumn("IDIntervjua").LazyLoad().Cascade.All().Inverse();
        }
    }
}
