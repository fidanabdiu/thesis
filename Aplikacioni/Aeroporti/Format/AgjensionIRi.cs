using System;
using System.Windows.Forms;
using BiznesLogjika;

namespace Aeroporti.Format
{
    public partial class AgjensionIRi : FormatBaze.DialoguBaze
    {
        private Agjensioni aAgjensioni;
        
        public AgjensionIRi(Agjensioni a)
        {
            InitializeComponent();

            aAgjensioni = a;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtEmri.Text.Length == 0)
            {
                Mesazhi("Shkruajeni emrin e agjensionit");
                txtEmri.Focus();
            }
            else
            {
                aAgjensioni.Emri = txtEmri.Text;

                DialogResult = DialogResult.OK;
            }
        }
    }
}
