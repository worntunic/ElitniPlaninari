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

namespace Izbori.WriteForme.PomocneForme
{
    public partial class DodajTekstPrimedbe : Form
    {
        public string RetValString { get; set; }

        public DodajTekstPrimedbe()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0 || textBox1.TextLength > 180)
                SystemSounds.Beep.Play();
            else
            {
                RetValString = textBox1.Text;

                DialogResult = DialogResult.OK;

                Close();
            }

        }
    }
}
