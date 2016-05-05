using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Izbori.Entiteti;

namespace Izbori.Mapiranja
{
    public class AktivistaMapiranja : ClassMap<Aktivista>
    {
        public AktivistaMapiranja()
        {
            Table("Aktivistastranke");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Ime, "lime");
            Map(x => x.ImeRod, "imerod");
            Map(x => x.Prezime, "prezime");
            Map(x => x.Ulica, "ulica");
            Map(x => x.Broj, "broj");
            Map(x => x.Grad, "grad");

            HasMany(x => x.email).KeyColumn("IDAkt").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.brTel).KeyColumn("IDAkt").LazyLoad().Cascade.All().Inverse();

            References(x => x.koord).Column("IDKOORD").LazyLoad();

            HasManyToMany(x => x.Akcije)
                .Table("AktivnostiAktivista")
                .ParentKeyColumn("IDAkt")
                .ChildKeyColumn("IDAkc");
            HasMany(x => x.Primedbe).KeyColumn("IDAkt").Inverse().Cascade.All();
            //References(x => x.IDGM).Column("IDGM").LazyLoad();
        }
    }
}
