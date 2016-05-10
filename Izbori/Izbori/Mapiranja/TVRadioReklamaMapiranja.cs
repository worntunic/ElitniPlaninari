using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Izbori.Entiteti;
using FluentNHibernate.Mapping;

namespace Izbori.Mapiranja
{
    public class TVRadioReklamaMapiranja : SubclassMap<TVRadioReklama>
    {
        public TVRadioReklamaMapiranja()
        {
            Table("TVRadioReklama");

            KeyColumn("ID");

            Map(x => x.BrojPonavljanja).Column("BrojPonavljanja");
            Map(x => x.Trajanje).Column("Trajanje");
            Map(x => x.NazivStanice).Column("NazivStanice");


        }
    }
}
