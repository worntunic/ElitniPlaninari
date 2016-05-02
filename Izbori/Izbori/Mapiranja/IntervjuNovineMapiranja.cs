using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Izbori.Entiteti;
using FluentNHibernate.Mapping;

namespace Izbori.Mapiranja
{
    class IntervjuNovineMapiranja : SubclassMap<IntervjuNovine>
    {
        public IntervjuNovineMapiranja()
        {
            Table("IntervjuNovine");
            
            KeyColumn("ID");
                        
            Map(x => x.NazivLista).Column("NazivLista");
            Map(x => x.DatumObjavljivanja).Column("DatumObjavljivanja");
            Map(x => x.DatumIntervjua).Column("DatumIntervjua");

            HasMany(x => x.Novinari).KeyColumn("Novinari").LazyLoad().Cascade.All().Inverse();
        }
    }
}
