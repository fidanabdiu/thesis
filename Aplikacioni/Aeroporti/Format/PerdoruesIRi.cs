using System;
using System.Windows.Forms;
using BiznesLogjika;

namespace Aeroporti.Format
{
    public partial class PerdoruesIRi : Aeroporti.FormatBaze.DialoguBaze
    {
        private PerdoruesiAeroportit aPerdoruesi;
        
        public PerdoruesIRi(PerdoruesiAeroportit p)
        {
            InitializeComponent();

            aPerdoruesi = p;

            VendosiDokumentetIdentifikuese();
            VendosiPrivilegjet();
        }

        private void VendosiPrivilegjet()
        {
            cboPrivilegji.Items.AddRange(Enum.GetNames(typeof(Privilegji)));
        }

        private void VendosiDokumentetIdentifikuese()
        {
            cboDokumentiIdentifikues.Items.AddRange(Enum.GetNames(typeof(DokumentiIdentifikues)));
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtEmri.Text.Length == 0)
            {
                Mesazhi("Jipeni emrin");
                txtEmri.Focus();
            }
            else if (txtMbiemri.Text.Length == 0)
            {
                Mesazhi("Jipeni mbiemrin");
                txtMbiemri.Focus();
            }
            else if (txtNumriIdentifikues.Text.Length == 0)
            {
                Mesazhi("Jipeni numrin identifikues");
                txtNumriIdentifikues.Focus();
            }
            else if (cboDokumentiIdentifikues.SelectedItem == null)
            {
                Mesazhi("Zgjedheni llojin e dokumentit identifikues");
                cboDokumentiIdentifikues.DroppedDown = true;
            }
            else if (txtVendlindja.Text.Length == 0)
            {
                Mesazhi("Jipeni vendlindjen");
                txtVendlindja.Focus();
            }
            else if (cboPrivilegji.SelectedItem == null)
            {
                Mesazhi("Zgjedheni privilegjin");
                cboPrivilegji.DroppedDown = true;
            }
            else if (txtPseudonimi.Text.Length == 0)
            {
                Mesazhi("Jipeni pseudonimin");
                txtPseudonimi.Focus();
            }
            else
            {
                aPerdoruesi.Emri = txtEmri.Text;
                aPerdoruesi.Mbiemri = txtMbiemri.Text;
                aPerdoruesi.NumriIdentifikues = txtNumriIdentifikues.Text;
                aPerdoruesi.DokumentiIdentifikues = (DokumentiIdentifikues)Enum.Parse(typeof(DokumentiIdentifikues), cboDokumentiIdentifikues.Text);
                aPerdoruesi.Datelindja = dtpDatelindja.Value;
                aPerdoruesi.Vendlindja = txtVendlindja.Text;
                aPerdoruesi.Vendbanimi = txtVendbanimi.Text;
                aPerdoruesi.Adresa = txtAdresa.Text;
                aPerdoruesi.TelefoniFiks = txtTelefoniFiks.Text;
                aPerdoruesi.TelefoniMobil = txtTelefoniMobil.Text;
                aPerdoruesi.Emaili = txtEmail.Text;
                aPerdoruesi.Pseudonimi = txtPseudonimi.Text;
                aPerdoruesi.Privilegji = (Privilegji)Enum.Parse(typeof(Privilegji), cboPrivilegji.Text);

                DialogResult = DialogResult.OK;
            }
        }
    }
}
