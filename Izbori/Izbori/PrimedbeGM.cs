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
    public partial class PrimedbeGM : Form
    {
        public List<Entiteti.Aktivista> aktNaGm;
        public List<Entiteti.Primedbe> primedbeNaGm;
        public Entiteti.Primedbe odbPrim;

        public PrimedbeGM()
        {
            InitializeComponent();
            aktNaGm = new List<Entiteti.Aktivista>();
            primedbeNaGm = new List<Entiteti.Primedbe>();
            odbPrim = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(odbPrim == null)
            {
                MessageBox.Show("Morate odabrati primedbu koju želite da obrišete.", "Greška");
            } else
            {
                try
                {
                    ISession s = DataLayer.GetSession();
                    odbPrim.Aktivista = null;
                    odbPrim.GlasackoMesto = null;
                    s.SaveOrUpdate(odbPrim);
                    s.Close();
                    ((Form1)Owner).obrisi<Entiteti.Primedbe>(odbPrim.ID);
                    lbPrimedbe.Items.Remove(odbPrim.TekstPrim);
                    odbPrim = null;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!(((ComboBox)sender).Text == ""))
            {
                Entiteti.Aktivista odb = aktNaGm[((ComboBox)sender).SelectedIndex];
                foreach(var p in primedbeNaGm.Where(pr => pr.Aktivista == odb).ToList())
                {
                    lbPrimedbe.Items.Add(p.TekstPrim);
                }
            }
        }

        private void PrimedbeGM_Load(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                aktNaGm = (List<Entiteti.Aktivista>)s
                    .QueryOver<Entiteti.Aktivista>()
                    .Where(a => a.gm == ((Form1)Owner).oGM).List();
                primedbeNaGm = (List<Entiteti.Primedbe>)s.QueryOver<Entiteti.Primedbe>()
                                .Where(p => p.GlasackoMesto == ((Form1)Owner).oGM).List();
                odbPrim = null;
                s.Close();

                foreach(var a in aktNaGm)
                {
                    cbAkt.Items.Add(a.Ime + " " + a.Prezime);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dodajPrim_Click(object sender, EventArgs e)
        {
            if(cbAkt.Text == "")
            {
                MessageBox.Show("Morate odabrati aktivistu kome želite da dodate primedbu.", "Greška");
            } else
            {
                WriteForme.PomocneForme.DodajTekstPrimedbe f = new WriteForme.PomocneForme.DodajTekstPrimedbe();
                f.ShowDialog(this);
                try
                {
                    ISession s = DataLayer.GetSession();
                    var akt = aktNaGm[cbAkt.SelectedIndex];
                    var prim = new Entiteti.Primedbe
                                            {
                                                GlasackoMesto = ((Form1)Owner).oGM,
                                                Aktivista = akt,
                                                TekstPrim = f.RetValString
                                            };
                    s.Save(prim);
                    s.Flush();
                    s.Close();
                    primedbeNaGm.Add(prim);
                    lbPrimedbe.Items.Add(prim.TekstPrim);
                    lbPrimedbe.SelectedItem = prim.TekstPrim;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void azurPrimedbu_Click(object sender, EventArgs e)
        {
            if (lbPrimedbe.SelectedItem == null)
            {
                MessageBox.Show("Morate odabrati primedbu koju želite da izmenite.", "Greška");
            }
            else
            {
                WriteForme.PomocneForme.DodajTekstPrimedbe f = new WriteForme.PomocneForme.DodajTekstPrimedbe(
                                                                   lbPrimedbe.SelectedItem.ToString());
                f.ShowDialog(this);
                try
                {
                    ISession s = DataLayer.GetSession();
                    odbPrim.TekstPrim = f.RetValString;
                    s.SaveOrUpdate(odbPrim);
                    s.Flush();
                    s.Close();
                    lbPrimedbe.Items[lbPrimedbe.SelectedIndex] = odbPrim.TekstPrim;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void lbPrimedbe_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ind = ((ListBox)sender).SelectedIndex;
            if(ind == -1)
            {
                odbPrim = null;
            } else
            {
                odbPrim = primedbeNaGm[ind];
            }
        }
    }
}
