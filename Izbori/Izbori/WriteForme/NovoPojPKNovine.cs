using NHibernate;
using Izbori.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Izbori.WriteForme
{
    public partial class NovoPojPKNovine : Form
    {
        public NovoPojPKNovine()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (DateTime.Compare(dateIntervjua.Value.Date, dateObjavljivanja.Value.Date) > 0)
            {
                MessageBox.Show("Datum intervjua ne sme biti posle datuma objavljivanja!", "Greška!");
                return;
            }

            ISession ses = DataLayer.GetSession();
            try
            {
                ses.Transaction.Begin();

                var poj = new IntervjuNovine
                {
                    NazivLista = tbNazivLista.Text,
                    DatumIntervjua = dateIntervjua.Value.Date,
                    DatumObjavljivanja= dateObjavljivanja.Value.Date
                };

                ses.Save(poj);
                foreach (string x in cbNovinari.Items)
                {
                    var novinar = new NovinariIzNovina()
                    {
                        IDIntervjua = poj,
                        ImeNovinara = x
                    };
                    ses.Save(novinar);
                }

                ses.Transaction.Commit();

                MessageBox.Show("Pojavljivanje predsedničkog kandidata u novinama je uspešno sačuvano!", "Uspeh!");
            }
            catch (Exception ex)
            {
                ses.Transaction.Rollback();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ses.Close();
            }
        }

        private void btnAddNovinar_Click(object sender, EventArgs e)
        {
            if (!cbNovinari.Text.Length.Equals(0))
            {
                cbNovinari.Items.Add(cbNovinari.Text);
                cbNovinari.Text = "";
            }
            else
                SystemSounds.Beep.Play();
        }

        private void btnRemoveNovinar_Click(object sender, EventArgs e)
        {
            cbNovinari.Items.Remove(cbNovinari.SelectedItem);
        }
    }
}
