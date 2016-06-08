using Izbori.Entiteti;
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
        private IList<Gost> lista;
        public DodajGosta(IList<Gost> temp)
        {
            InitializeComponent();
            lista = temp;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var g = new Gost()
            {
                Ime = tbIme.Text,
                Prezime = tbPrezime.Text,
                Titula = tbTitula.Text,
                Funkcija = tbFunkcija.Text
            };

            lista.Add(g);

            MessageBox.Show("Gost uspešno dodat!", "Uspeh!");

            this.Close();
        }
    }
}
