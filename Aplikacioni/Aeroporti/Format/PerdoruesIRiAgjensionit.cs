using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BiznesLogjika;
using ShtresaETeDhenave;

namespace Aeroporti.Format
{
    public partial class PerdoruesIRiAgjensionit : FormatBaze.DialoguBaze
    {
        private PerdoruesiAgjensionit aPerdoruesiAgjensionit;
        
        public PerdoruesIRiAgjensionit(PerdoruesiAgjensionit pa)
        {
            InitializeComponent();

            aPerdoruesiAgjensionit = pa;

            VendosiDokumentetIdentifikuese();
            VendosiPrivilegjet();
            VendosiAgjensionet();
        }

        private void VendosiAgjensionet()
        {
            List<Agjensioni> la = new List<Agjensioni>();

            AgjensionetDB adb = new AgjensionetDB(la);
            adb.Lexo("");

            foreach (Agjensioni a in la)
                cboAgjensionet.Items.Add(a);
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
            if (cboAgjensionet.SelectedItem == null)
            {
                Mesazhi("Zgjedheni agjensionin");
                cboAgjensionet.DroppedDown = true;
            }            
            else if (txtEmri.Text.Length == 0)
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
                aPerdoruesiAgjensionit.Agjensioni = (Agjensioni)cboAgjensionet.SelectedItem;
                aPerdoruesiAgjensionit.Emri = txtEmri.Text;
                aPerdoruesiAgjensionit.Mbiemri = txtMbiemri.Text;
                aPerdoruesiAgjensionit.NumriIdentifikues = txtNumriIdentifikues.Text;
                aPerdoruesiAgjensionit.DokumentiIdentifikues = (DokumentiIdentifikues)Enum.Parse(typeof(DokumentiIdentifikues), cboDokumentiIdentifikues.Text);
                aPerdoruesiAgjensionit.Datelindja = dtpDatelindja.Value;
                aPerdoruesiAgjensionit.Vendlindja = txtVendlindja.Text;
                aPerdoruesiAgjensionit.Vendbanimi = txtVendbanimi.Text;
                aPerdoruesiAgjensionit.Adresa = txtAdresa.Text;
                aPerdoruesiAgjensionit.TelefoniFiks = txtTelefoniFiks.Text;
                aPerdoruesiAgjensionit.TelefoniMobil = txtTelefoniMobil.Text;
                aPerdoruesiAgjensionit.Emaili = txtEmail.Text;
                aPerdoruesiAgjensionit.Pseudonimi = txtPseudonimi.Text;
                aPerdoruesiAgjensionit.Privilegji = (Privilegji)Enum.Parse(typeof(Privilegji), cboPrivilegji.Text);

                DialogResult = DialogResult.OK;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Agjensioni a = new Agjensioni();

            AgjensionIRi forma = new AgjensionIRi(a);

            if (forma.ShowDialog() == DialogResult.OK)
            {
                AgjensioniDB adb = new AgjensioniDB(a);
                adb.Shkruaj();

                cboAgjensionet.Items.Add(a);
                cboAgjensionet.SelectedItem = a;
            }
        }
    }
}
