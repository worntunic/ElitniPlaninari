using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Izbori.Entiteti;

namespace Izbori.Entiteti
{
    public class EMailAktiviste
    {
        public virtual int IDEmail { get; set; }
        public virtual Aktivista Akt { get; set; }
        public virtual string eMail { get; set; }

    }
}
