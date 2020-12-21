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
    public partial class PerdoruesIRi : FormatBaze.DialoguBaze
    {
        private PerdoruesiAgjensionit aPerdoruesi;
        
        public PerdoruesIRi(PerdoruesiAgjensionit p)
        {
            InitializeComponent();

            aPerdoruesi = p;

            VendosiDokumentetIdentifikuese();
            VendosiPrivilegjet();
        }

        private void VendosiDokumentetIdentifikuese()
        {
            cboDokumentiIdentifikues.Items.AddRange(Enum.GetNames(typeof(DokumentiIdentifikues)));
        }

        private void VendosiPrivilegjet()
        {
            cboPrivilegji.Items.AddRange(Enum.GetNames(typeof(Privilegji)));
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

                aPerdoruesi.Agjensioni = Veglat.Veglat.PerdoruesiIKycur.Agjensioni;

                DialogResult = DialogResult.OK;
            }
        }
    }
}
