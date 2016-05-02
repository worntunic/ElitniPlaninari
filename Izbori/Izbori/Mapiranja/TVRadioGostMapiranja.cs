using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Izbori.Entiteti;
using FluentNHibernate.Mapping;

namespace Izbori.Mapiranja
{
    class TVRadioGostMapiranja : SubclassMap<TVRadioGost>
    {
        public TVRadioGostMapiranja()
        {
            Table("TVRadioGost");

            KeyColumn("ID");

            Map(x => x.ID).Column("ID");
            Map(X => X.NazivStanice).Column("NazivStanice");
            Map(X => X.NazivEmisije).Column("NazivEmisije");
            Map(X => X.ImeVoditelja).Column("ImeVoditelja");
            Map(X => X.Gledanost).Column("Gledanost");
        }
    }
}