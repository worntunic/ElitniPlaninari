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
    public partial class ImePrezime : Form
    {
        public ImePrezime()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                var odb = new Entiteti.Aktivista();
                
                odb.Ime = aktIme.Text;
                odb.ImeRod = aktImeRod.Text;
                odb.Prezime = aktPrez.Text;

                s.SaveOrUpdate(odb);
                s.Flush();
                s.Close();

                this.Close();

                ((Form1)Owner).odabrani = odb;
                ((Form1)Owner).aktivisti.Add(odb);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
