using System;
using System.Windows.Forms;
using BiznesLogjika;

namespace Aeroporti.Format
{
    public partial class ShtetIRi : FormatBaze.DialoguBaze
    {
        private Shteti aShteti;
        
        public ShtetIRi(Shteti sh)
        {
            InitializeComponent();

            aShteti = sh;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtEmri.Text.Length == 0)
            {
                Mesazhi("Shkruajeni emrin e shtetit");
                txtEmri.Focus();
            }
            else
            {
                aShteti.Emri = txtEmri.Text;

                DialogResult = DialogResult.OK;
            }
        }
    }
}
