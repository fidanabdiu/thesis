using System;
using System.Windows.Forms;
using BiznesLogjika;

namespace Aeroporti.Format
{
    public partial class MarkeERe : FormatBaze.DialoguBaze
    {
        private MarkaAeroplanit aMarkaAeroplanit;
        
        public MarkeERe(MarkaAeroplanit ma)
        {
            InitializeComponent();

            aMarkaAeroplanit = ma;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtMarka.Text.Length == 0)
                Mesazhi("Shkruajeni markën e aeroplanit");
            else
            {
                aMarkaAeroplanit.Emri = txtMarka.Text;

                DialogResult = DialogResult.OK;
            }
        }
    }
}
