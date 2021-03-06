﻿using Izbori.Entiteti;
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

namespace Izbori.WriteForme
{
    public partial class NovoPojPKTVRadio : Form
    {
        public TVRadioGost RetValPoj { get; set; }

        public NovoPojPKTVRadio()
        {
            InitializeComponent();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
                e.Handled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ISession ses = DataLayer.GetSession();

            try
            {
                ses.Transaction.Begin();

                RetValPoj = new TVRadioGost
                {
                    NazivStanice = tbNazivStanice.Text,
                    NazivEmisije = tbNazivEmisije.Text,
                    ImeVoditelja = tbImeVoditelja.Text,
                    Gledanost = int.Parse(tbGledanost.Text)
                };

                ses.SaveOrUpdate(RetValPoj);

                ses.Transaction.Commit();

                DialogResult = DialogResult.OK;

                MessageBox.Show("Pojavljivanje predsedničkog kandidata na TV-u ili Radiju je uspešno sačuvano!", "Uspeh!");
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
    }
}
