using System;
using System.Windows.Forms;
using BiznesLogjika;

namespace Aeroporti.Format
{
    public partial class TipIRi : FormatBaze.DialoguBaze
    {
        private TipiAeroplanit aTipiAeroplanit;
        
        public TipIRi(TipiAeroplanit ta)
        {
            InitializeComponent();

            aTipiAeroplanit = ta;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtTipi.Text.Length == 0)
                Mesazhi("Shkruajeni tipin e aeroplanit");
            else
            {
                aTipiAeroplanit.Emri = txtTipi.Text;

                DialogResult = DialogResult.OK;
            }
        }
    }
}
