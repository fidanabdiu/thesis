using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BiznesLogjika;
using ShtresaETeDhenave;

namespace Aeroporti.Format
{
    public partial class QytetIRi : FormatBaze.DialoguBaze
    {
        private Qyteti aQyteti;
        
        public QytetIRi(Qyteti q)
        {
            InitializeComponent();

            aQyteti = q;

            VendosiShtetet();
        }

        private void VendosiShtetet()
        {
            List<Shteti> lsh = new List<Shteti>();

            ShtetetDB shdb = new ShtetetDB(lsh);
            shdb.Lexo("");

            cboShtetet.Items.AddRange(lsh.ToArray());
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtEmri.Text.Length == 0)
            {
                Mesazhi("Shkruajeni emrin");
                txtEmri.Focus();
            }
            else if (cboShtetet.SelectedItem == null)
            {
                Mesazhi("Zgjedheni shtetin");
                cboShtetet.DroppedDown = true;
            }
            else
            {
                aQyteti.Emri = txtEmri.Text;
                aQyteti.Shteti = (Shteti)cboShtetet.SelectedItem;

                DialogResult = DialogResult.OK;
            }
        }

        private void btnShtoShtet_Click(object sender, EventArgs e)
        {
            Shteti sh = new Shteti();

            ShtetIRi forma = new ShtetIRi(sh);

            if (forma.ShowDialog() == DialogResult.OK)
            {
                ShtetiDB shdb = new ShtetiDB(sh);
                shdb.Shkruaj();

                cboShtetet.Items.Add(sh);
                cboShtetet.SelectedItem = sh;
            }
        }
    }
}
