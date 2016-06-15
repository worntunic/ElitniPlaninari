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
        public DodajPomoc()
        {
            InitializeComponent();

            akt = null;
        }

        

        private void DodajPomoc_Load(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                akt = s.QueryOver<Aktivista>()
                    .Where(a => a.koord == null)
                    .List();

                IList<int> krdID = s.QueryOver<Koordinator>().Select(k=> k.ID).List<int>();

                akt = akt.Where(a => !krdID.Contains(a.ID)).ToList();
                
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
                        Koordinator k = (Koordinator)((Form1)Owner).odabrani;
                        saradnik.koord = k;

                        s.Update(saradnik);
                        s.Flush();
                        s.Close();

                        ((Form1)Owner).osveziPolja(k.ID);

                        this.Close();
                    }
                }
                else {
                    MessageBox.Show("Morate odabrati barem jednog aktivistu!", "Greška");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
