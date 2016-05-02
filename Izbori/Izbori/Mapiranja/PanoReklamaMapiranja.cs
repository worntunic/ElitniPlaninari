using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Izbori.Entiteti;
using FluentNHibernate.Mapping;

namespace Izbori.Mapiranja
{
    class PanoReklamaMapiranja : SubclassMap<PanoReklama>
    {
        public PanoReklamaMapiranja()
        {
            Table("PanoReklama");

            KeyColumn("ID");

            Map(x => x.ID).Column("ID");
            Map(x => x.Grad).Column("Grad");
            Map(x => x.Ulica).Column("Ulica");
            Map(x => x.Vlasnik).Column("Vlasnik");
            Map(x => x.Povrsina).Column("Povrsina");
        }
    }
}
