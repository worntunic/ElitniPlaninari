using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbori.Entiteti
{
    class PanoReklama : Reklama
    {
        public virtual string Grad { get; set; }
        public virtual string Ulica { get; set; }
        public virtual string Vlasnik { get; set; }
        public virtual double Povrsina { get; set; }
    }
}
