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
    public partial class DodajAkciju : Form
    {
        public Akcija RetValAkc { get; set; }

        public DodajAkciju()
        {
            InitializeComponent();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void rBtnDeljLet_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnDeljLet.Checked == true)
            {
                rBtnSusKand.Checked = false;
                rBtnMiting.Checked = false;
                lLokacija.Visible = false;
                tbLokacija.Visible = false;
                cbZatProst.Visible = false;

                lNazivIznajmljivaca.Visible = false;
                lCenaZakupa.Visible = false;
                tbNazivIznajmljivaca.Visible = false;
                tbCenaZakupa.Visible = false;

                cbZatProst.CheckState = CheckState.Unchecked;
            }
        }
        private void rBtnSusKand_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnSusKand.Checked == true)
            {
                rBtnDeljLet.Checked = false;
                rBtnMiting.Checked = false;
                lLokacija.Visible = true;
                tbLokacija.Visible = true;
                cbZatProst.Visible = false;

                lNazivIznajmljivaca.Visible = false;
                lCenaZakupa.Visible = false;
                tbNazivIznajmljivaca.Visible = false;
                tbCenaZakupa.Visible = false;

                cbZatProst.CheckState = CheckState.Unchecked;
            }
        }
        private void rBtnMiting_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnMiting.Checked == true)
            {
                rBtnSusKand.Checked = false;
                rBtnDeljLet.Checked = false;
                lLokacija.Visible = true;
                tbLokacija.Visible = true;
                cbZatProst.Visible = true;

                lNazivIznajmljivaca.Visible = false;
                lCenaZakupa.Visible = false;
                tbNazivIznajmljivaca.Visible = false;
                tbCenaZakupa.Visible = false;
            }
        }
        private void cbZatProst_CheckedChanged(object sender, EventArgs e)
        {
            if (cbZatProst.CheckState == CheckState.Checked)
            {
                lNazivIznajmljivaca.Visible = true;
                lCenaZakupa.Visible = true;
                tbNazivIznajmljivaca.Visible = true;
                tbCenaZakupa.Visible = true;
            }
            else if (cbZatProst.CheckState == CheckState.Unchecked)
            {
                lNazivIznajmljivaca.Visible = false;
                lCenaZakupa.Visible = false;
                tbNazivIznajmljivaca.Visible = false;
                tbCenaZakupa.Visible = false;
            }

        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            var enabledTB = ((Form1)Owner).GetAll(this, typeof(TextBox));
            enabledTB = enabledTB.Where(tb => tb.Visible == true);
            bool nesve = false;
            foreach(var etb in enabledTB)
            {
                if(etb.Text == "")
                {
                    nesve = true;
                    break;
                }
            }
            if (nesve)
            {
                MessageBox.Show("Morate popuniti sva polja!", "Greška");
                return;
            }
            ISession s = DataLayer.GetSession();
            try
            {
                if (rBtnDeljLet.Checked == true)
                {
                    RetValAkc = new DeljenjeLetaka
                    {
                        NazivAkcije = tbNazivAkcije.Text,
                        Grad = tbGrad.Text
                    };
                    s.SaveOrUpdate(RetValAkc);
                    DialogResult = DialogResult.OK;
                    MessageBox.Show("Akcija deljenja letaka je uspesno dodata!", "Uspeh!");
                }
                else if (rBtnSusKand.Checked == true)
                {
                    RetValAkc = new SusretKandidata
                    {
                        NazivAkcije = tbNazivAkcije.Text,
                        Grad = tbGrad.Text,
                        Lokacija = tbLokacija.Text
                    };
                    s.SaveOrUpdate(RetValAkc);
                    DialogResult = DialogResult.OK;
                    MessageBox.Show("Akcija susreta kandidata je uspesno dodata!", "Uspeh!");
                }
                else if (rBtnMiting.Checked == true && cbZatProst.CheckState == CheckState.Checked)
                {
                    RetValAkc = new MitingZatvoreniP
                    {
                        NazivAkcije = tbNazivAkcije.Text,
                        Grad = tbGrad.Text,
                        Lokacija = tbLokacija.Text,
                        NazivIznajmljivaca = tbNazivIznajmljivaca.Text,
                        Cena = int.Parse(tbCenaZakupa.Text)
                    };
                    s.SaveOrUpdate(RetValAkc);
                    DialogResult = DialogResult.OK;
                    MessageBox.Show("Akcija mitinga u zatvorenom prostoru je uspesno dodata!", "Uspeh!");
                }
                else if (rBtnMiting.Checked == true && cbZatProst.CheckState == CheckState.Unchecked)
                {
                    RetValAkc = new Miting
                    {
                        NazivAkcije = tbNazivAkcije.Text,
                        Grad = tbGrad.Text,
                        Lokacija = tbLokacija.Text
                    };
                    s.SaveOrUpdate(RetValAkc);
                    DialogResult = DialogResult.OK;
                    MessageBox.Show("Akcija mitinga je uspesno dodata!", "Uspeh!");
                }
                else
                {
                    MessageBox.Show("Izaberite jednu od vrsta akcija iznad!","Greska");
                }                    
            }
            catch(System.FormatException ex)
            {
                MessageBox.Show("Morate popuniti sva polja!", "Greška");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                s.Close();
            }
        }
    }
}
