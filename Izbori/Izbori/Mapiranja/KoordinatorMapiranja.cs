using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Izbori.Entiteti;

namespace Izbori.Mapiranja
{
    public class KoordinatorMapiranja : SubclassMap<Koordinator>
    {
        public KoordinatorMapiranja()
        {
            Table("KOORDINATOR");

            KeyColumn("IDAkt");

            Map(x => x.Opstina);
            Map(x => x.UlicaKanc, "ULICA");
            Map(x => x.BrojKanc, "BROJ");
            Map(x => x.GradKanc, "GRAD");

            HasMany(x => x.Saradnici).KeyColumn("ID").LazyLoad().Cascade.All().Inverse();
        }
    }
}
