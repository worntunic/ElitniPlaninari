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

namespace Izbori
{
    public partial class DodajPomoc : Form
    {
        IList<Aktivista> akt;
        Type tip;
        public DodajPomoc(Type aktTip)
            //AktTip je tip koji sluzi kao fleg
        {
            InitializeComponent();
            akt = null;
            tip = aktTip;
        }

        

        private void DodajPomoc_Load(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                if (tip == typeof(Aktivista))
                {
                    akt = s.QueryOver<Aktivista>()
                        .Where(a => a.koord == null)
                        .List();

                    IList<int> krdID = s.QueryOver<Koordinator>().Select(k=> k.ID).List<int>();

                    akt = akt.Where(a => !krdID.Contains(a.ID)).ToList();
                } else if (tip == typeof(GlasackoMesto))
                {
                    akt = s.QueryOver<Aktivista>().Where(g => g.gm == null).List();
                }
                
                ((Form1)Owner).ucitajAkt(lvPomoc, akt);
                s.Close();
                   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                if(lvPomoc.SelectedItems.Count == 1)
                {
                    ListView.SelectedListViewItemCollection sar = lvPomoc.SelectedItems;
                    foreach (ListViewItem p in sar)
                    {
                        int id = Int32.Parse(p.SubItems[0].Text);
                        Aktivista saradnik = akt.Single(a => a.ID == id);
                        if (tip == typeof(Aktivista))
                        {

                            Koordinator k = (Koordinator)((Form1)Owner).odabrani;
                            saradnik.koord = k;

                            s.Update(saradnik);
                            s.Flush();
                            s.Close();

                            ((Form1)Owner).osveziPolja(k.ID); 
                        } else if (tip == typeof(GlasackoMesto))
                        {
                            saradnik.gm = ((Form1)Owner).oGM;

                            s.Update(saradnik);
                            s.Flush();
                            s.Close();

                            ((Form1)Owner).osveziGM(((Form1)Owner).oGM.ID);
                        }

                        this.Close();
                    }
                }
                else {
                    MessageBox.Show("Morate odabrati barem jednog aktivistu!", "Greška");
                    s.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
