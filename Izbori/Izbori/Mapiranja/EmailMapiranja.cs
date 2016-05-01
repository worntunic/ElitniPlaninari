using FluentNHibernate.Mapping;
using Izbori.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbori.Mapiranja
{
    public class EmailMapiranja : ClassMap<EMailAktiviste>
    {
        public EmailMapiranja()
        {
            Table("EMAILAKTIVISTA");

            Id(x => x.IDEmail, "IDEmail").GeneratedBy.TriggerIdentity();

            References(x => x.Akt).Column("IDakt").LazyLoad();

            Map(x => x.eMail, "EMAIL");
        }
    }
}
