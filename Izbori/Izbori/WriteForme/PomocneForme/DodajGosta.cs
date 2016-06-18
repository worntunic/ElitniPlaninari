using Izbori.Entiteti;
using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Izbori.WriteForme.PomocneForme
{
    public partial class DodajGosta : Form
    {
        public Gost RetValGost { get; set; }

        public DodajGosta()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            try
            {
                RetValGost = new Gost()
                {
                    Ime = tbIme.Text,
                    Prezime = tbPrezime.Text,
                    Titula = tbTitula.Text,
                    Funkcija = tbFunkcija.Text
                };
                s.SaveOrUpdate(RetValGost);

                s.Flush();

                DialogResult = DialogResult.OK;
            }
            finally
            {
                Close();
            }
        }
    }
}
