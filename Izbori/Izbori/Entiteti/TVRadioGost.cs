using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbori.Entiteti
{
    public class TVRadioGost 
    {        
        public virtual int ID { get; set; }
        public virtual string NazivStanice { get; set; }
        public virtual string NazivEmisije { get; set; }
        public virtual string ImeVoditelja { get; set; }
        public virtual int Gledanost { get; set; }
    }
}
