using System;
using System.Windows.Forms;
using BiznesLogjika;

namespace Aeroporti.Format
{
    public partial class Fjalekalimi : Aeroporti.FormatBaze.DialoguBaze
    {
        private PerdoruesiAeroportit aPerdoruesi;
        
        public Fjalekalimi(PerdoruesiAeroportit p)
        {
            InitializeComponent();

            aPerdoruesi = p;

            VendosePerdoruesin();
        }

        private void VendosePerdoruesin()
        {
            lblEmriMbiemri.Text = aPerdoruesi.Emri + " " + aPerdoruesi.Mbiemri;
            lblPrivilegji.Text = aPerdoruesi.Privilegji.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtFjalekalimiVjeter.Text.Length == 0 || txtFjalekalimiRi.Text.Length == 0 || txtFjalekalimiRi2.Text.Length == 0)
            {
                Mesazhi("Të gjitha fushat duhet të plotësohen");
            }
            else if (Veglat.Veglat.PerdoruesiIKycur.Fjalekalimi != txtFjalekalimiVjeter.Text)
            {
                Mesazhi("Fjalëkalimi i vjetër është gabim");
            }
            else if (txtFjalekalimiRi.Text != txtFjalekalimiRi2.Text)
            {
                Mesazhi("Fjalëkalimet e reja nuk përputhen");
            }
            else
            {
                aPerdoruesi.Fjalekalimi = txtFjalekalimiRi.Text;

                DialogResult = DialogResult.OK;
            }
        }
    }
}
