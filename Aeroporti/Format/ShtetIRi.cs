using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BiznesLogjika;

namespace Aeroporti.Format
{
    public partial class ShtetIRi : Aeroporti.FormatBaze.DialoguBaze
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
