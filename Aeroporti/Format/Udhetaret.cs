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
using Aeroporti.Listat;

namespace Aeroporti.Format
{
    public partial class Udhetaret : FormatBaze.EntitetetBaze
    {
        private static Udhetaret instanca = null;
        
        private Udhetaret()
        {
            InitializeComponent();

            VendosiUdhetaret("");
        }

        public static Udhetaret MerreInstancen()
        {
            if (instanca == null)
            {
                instanca = new Udhetaret();
                return instanca;
            }
            else
                return instanca;
        }

        private void VendosiUdhetaret(string fjalakyce)
        {
            lvUdhetaret.Items.Clear();

            List<Udhetari> lu = new List<Udhetari>();

            UdhetaretDB udb = new UdhetaretDB(lu);
            udb.Lexo(fjalakyce);

            foreach (Udhetari u in lu)
                lvUdhetaret.Items.Add(new UdhetariListe(u));
        }

        private void btnKerkoAgjension_Click(object sender, EventArgs e)
        {
            Kerko forma = new Kerko();

            if (forma.ShowDialog() == DialogResult.OK)
                VendosiUdhetaret(forma.FjalaKyce);
        }

        private void btnFreskoAgjensionet_Click(object sender, EventArgs e)
        {
            VendosiUdhetaret("");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                    components.Dispose();
            }
            base.Dispose(disposing);
            instanca = null;
        }
    }
}
