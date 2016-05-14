using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Izbori.Entiteti;
using FluentNHibernate.Mapping;

namespace Izbori.Mapiranja
{
    public class TVRadioGostMapiranja : ClassMap<TVRadioGost>
    {
        public TVRadioGostMapiranja()
        {
            Table("TVRadioGost");

            Id(x => x.ID).GeneratedBy.TriggerIdentity();
                        
            Map(X => X.NazivStanice).Column("NazivStanice");
            Map(X => X.NazivEmisije).Column("NazivEmisije");
            Map(X => X.ImeVoditelja).Column("ImeVoditelja");
            Map(X => X.Gledanost).Column("Gledanost");
        }
    }
}