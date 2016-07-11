using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AgjensioniTuristik.Serveri;

namespace AgjensioniTuristik.Format
{
    public partial class Fjalekalimi : FormatBaze.DialoguBaze
    {
        private PerdoruesiAgjensionit aPerdoruesiAgjensionit;
        
        public Fjalekalimi(PerdoruesiAgjensionit pa)
        {
            InitializeComponent();

            aPerdoruesiAgjensionit = pa;

            VendosePerdoruesin();
        }

        private void VendosePerdoruesin()
        {
            lblEmriMbiemri.Text = aPerdoruesiAgjensionit.Emri + " " + aPerdoruesiAgjensionit.Mbiemri;
            lblPrivilegji.Text = aPerdoruesiAgjensionit.Privilegji.ToString();
        }

        private void grpFjalekalimi_Enter(object sender, EventArgs e)
        {

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
                aPerdoruesiAgjensionit.Fjalekalimi = txtFjalekalimiRi.Text;

                DialogResult = DialogResult.OK;
            }
        }
    }
}
