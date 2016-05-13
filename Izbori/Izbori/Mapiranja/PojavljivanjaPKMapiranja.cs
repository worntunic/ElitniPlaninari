using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Izbori.Entiteti;
using FluentNHibernate.Mapping;

namespace Izbori.Mapiranja
{
    public class PojavljivanjaPKMapiranja : ClassMap<PojavljivanjaPK>
    {
        public PojavljivanjaPKMapiranja()
        {
            Table("PojavljivanjaPK");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();            
        }
    }
}
