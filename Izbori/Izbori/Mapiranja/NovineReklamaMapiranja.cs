using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Izbori.Entiteti;
using FluentNHibernate.Mapping;

namespace Izbori.Mapiranja
{
    class NovineReklamaMapiranja : SubclassMap<NovineReklama>
    {
        public NovineReklamaMapiranja()
        {
            Table("NovineReklama");

            KeyColumn("ID");
            
            Map(x => x.Uboji).Column("Uboji");
            Map(x => x.NazivLista).Column("NazivLista");
        }
    }
}
