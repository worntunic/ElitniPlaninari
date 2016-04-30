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

namespace Izbori
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //komentar
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AkcDeljLetBtn_Click(object sender, EventArgs e) {
            try {
                ISession s = DataLayer.GetSession();


                Izbori.Entiteti.DeljenjeLetaka dl = new Izbori.Entiteti.DeljenjeLetaka();


                dl.NazivAkcije = "Posejimo ulice";
                dl.Grad = "Kruševac";
                s.Save(dl);

                s.Close();

            } catch (Exception ec) {
                MessageBox.Show(ec.Message);
            }
        }

        private void AkcSusKand_Click(object sender, EventArgs e) {
            try {
                ISession s = DataLayer.GetSession();


                Izbori.Entiteti.SusretKandidata sk = new Izbori.Entiteti.SusretKandidata();


                sk.NazivAkcije = "U susret budućnosti";
                sk.Grad = "Jagodina";
                sk.Lokacija = "Boks Klub Jagodinski Tigrovi";
                sk.PlaniranoVreme = new DateTime(2016, 5, 1, 18, 30, 0);

                s.Save(sk);

                s.Close();

            } catch (Exception ec) {
                MessageBox.Show(ec.Message);
            }
        }

        private void AkcMitBtn_Click(object sender, EventArgs e) {

        }
    }
}
