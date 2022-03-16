using System;
using System.Windows.Forms;
using AgjensioniTuristik.Serveri;

namespace AgjensioniTuristik.Format
{
    public partial class UdhetarIRi : FormatBaze.DialoguBaze
    {
        private Udhetari aUdhetari;
        
        public UdhetarIRi(Udhetari u)
        {
            InitializeComponent();

            aUdhetari = u;

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
            else
            {
                aUdhetari.Emri = txtEmri.Text;
                aUdhetari.Mbiemri = txtMbiemri.Text;
                aUdhetari.NumriIdentifikues = txtNumriIdentifikues.Text;
                aUdhetari.DokumentiIdentifikues = (DokumentiIdentifikues)Enum.Parse(typeof(DokumentiIdentifikues), cboDokumentiIdentifikues.Text);
                aUdhetari.Datelindja = dtpDatelindja.Value;
                aUdhetari.Vendlindja = txtVendlindja.Text;
                aUdhetari.Vendbanimi = txtVendbanimi.Text;
                aUdhetari.Adresa = txtAdresa.Text;
                aUdhetari.TelefoniFiks = txtTelefoniFiks.Text;
                aUdhetari.TelefoniMobil = txtTelefoniMobil.Text;
                aUdhetari.Emaili = txtEmail.Text;

                aUdhetari.PerdoruesiAgjensionit = Veglat.Veglat.PerdoruesiIKycur;

                DialogResult = DialogResult.OK;
            }
        }
    }
}
