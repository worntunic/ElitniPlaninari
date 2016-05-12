using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbori.Mapiranja {
    public class SusretKandidataMapiranja : SubclassMap<Izbori.Entiteti.SusretKandidata>{
        
        public SusretKandidataMapiranja() {
            Table("SusretKandidata");

            KeyColumn("ID");

            Map(x => x.Lokacija).Column("Lokacija");
            //Mozda cemo morati da dodamo ili CustomType("Date") ili CustomSqlType("Date") da bi
            //mapirali pravilno Date iz baze u c# DateTime. 
            //Ako ne uspe, moracemo da trazimo drugi nacin ili da promenimo Date u DateTime u bazi.
            Map(x => x.PlaniranoVreme).Column("PlaniranoVreme");
        }
    }
}
