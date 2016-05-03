using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbori.Entiteti
{
    public class Aktivista
    {
        public virtual int ID { get; set; }
        public virtual string Ime { get; set; }
        public virtual string ImeRod { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string Ulica { get; set; }
        public virtual int Broj { get; set; }
        public virtual string Grad { get; set; }
        public virtual Koordinator koord { get; set; } //id koordinatora ciji je pomconik
        //TODO Glasacko mesto
        //public virtual int IDGM { get; set; } //id glasackog mesta na kome je posmatrac
        public virtual IList<EMailAktiviste> email { get; set; }
        public virtual IList<BrTel> brTel { get; set; }
        public virtual IList<Akcija> Akcije { get; set; }
        public virtual IList<Primedbe> Primedbe { get; set; }
        public Aktivista()
        {
            email = new List<EMailAktiviste>();
            brTel = new List<BrTel>();
            Akcije = new List<Akcija>();
            Primedbe = new List<Primedbe>();
        }
    }

    public class Koordinator : Aktivista
    {
        //public virtual int IDAkt { get; set; }
        public virtual string Opstina { get; set; }
        public virtual string UlicaKanc { get; set; }
        public virtual string BrojKanc { get; set; }
        public virtual string GradKanc { get; set; }
        public virtual IList<Aktivista> Saradnici { get; set; }

        public Koordinator()
        {
            Saradnici = new List<Aktivista>();
        }
    }
}
