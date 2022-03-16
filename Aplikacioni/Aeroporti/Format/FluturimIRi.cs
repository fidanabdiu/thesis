using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BiznesLogjika;
using ShtresaETeDhenave;

namespace Aeroporti.Format
{
    public partial class FluturimIRi : FormatBaze.DialoguBaze
    {
        private Fluturimi aFluturimi;
        
        public FluturimIRi(Fluturimi f)
        {
            InitializeComponent();

            aFluturimi = f;

            VendosiAeroplanat();
            VendosiQytetet();
        }

        private void VendosiQytetet()
        {
            List<Qyteti> lq = new List<Qyteti>();

            QytetetDB qdb = new QytetetDB(lq);
            qdb.Lexo("");

            foreach (Qyteti q in lq)
                cboQytetet.Items.Add(q);
        }

        private void VendosiAeroplanat()
        {
            List<Aeroplani> la = new List<Aeroplani>();

            AeroplanatDB adb = new AeroplanatDB(la);
            adb.Lexo("");

            foreach (Aeroplani a in la)
                cboAeroplanat.Items.Add(a);
        }

        private void btnShtoAeroplan_Click(object sender, EventArgs e)
        {
            Aeroplani a = new Aeroplani();

            AeroplanIRi forma = new AeroplanIRi(a);

            if (forma.ShowDialog() == DialogResult.OK)
            {
                AeroplaniDB adb = new AeroplaniDB(a);
                adb.Shkruaj();

                cboAeroplanat.Items.Add(a);
                cboAeroplanat.SelectedItem = a;
            }
        }

        private void btnShtoQytet_Click(object sender, EventArgs e)
        {
            Qyteti q = new Qyteti();

            QytetIRi forma = new QytetIRi(q);

            if (forma.ShowDialog() == DialogResult.OK)
            {
                QytetiDB qdb = new QytetiDB(q);
                qdb.Shkruaj();

                cboQytetet.Items.Add(q);
                cboQytetet.SelectedItem = q;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cboAeroplanat.SelectedItem == null)
            {
                Mesazhi("Zgjedheni aeroplanin");
                cboAeroplanat.DroppedDown = true;
            }
            else if (cboQytetet.SelectedItem == null)
            {
                Mesazhi("Zgjedheni destinacionin");
                cboQytetet.DroppedDown = true;
            }
            else if (txtCmimi.Text.Length == 0)
            {
                Mesazhi("Shkruajeni çmimin");
                txtCmimi.Focus();
            }
            else if (txtCmimiKthyes.Text.Length == 0)
            {
                Mesazhi("Shkruajeni çmimin kthyes");
                txtCmimiKthyes.Focus();
            }
            else
            {
                aFluturimi.Aeroplani = (Aeroplani)cboAeroplanat.SelectedItem;
                aFluturimi.Qyteti = (Qyteti)cboQytetet.SelectedItem;
                aFluturimi.DataNisjes = dtpDataNisjes.Value;
                aFluturimi.OraNisjes = dtpOraNisjes.Value;
                aFluturimi.Cmimi = Convert.ToDecimal(txtCmimi.Text);
                aFluturimi.CmimiKthyes = Convert.ToDecimal(txtCmimiKthyes.Text);

                aFluturimi.PerdoruesiAeroportit = Veglat.Veglat.PerdoruesiIKycur;

                DialogResult = DialogResult.OK;
            }
        }
    }
}
