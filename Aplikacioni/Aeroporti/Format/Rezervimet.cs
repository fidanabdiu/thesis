using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BiznesLogjika;
using ShtresaETeDhenave;
using Aeroporti.Listat;

namespace Aeroporti.Format
{
    public partial class Rezervimet : FormatBaze.EntitetetBaze
    {
        private static Rezervimet instanca = null;
        
        private Rezervimet()
        {
            InitializeComponent();

            VendosiRezervimet("");
        }

        public static Rezervimet MerreInstancen()
        {
            if (instanca == null)
            {
                instanca = new Rezervimet();
                return instanca;
            }
            else
                return instanca;
        }

        private void VendosiRezervimet(string fjalakyce)
        {
            lvRezervimet.Items.Clear();

            List<Rezervimi> lr = new List<Rezervimi>();

            RezervimetDB rdb = new RezervimetDB(lr);
            rdb.Lexo(fjalakyce);

            foreach (Rezervimi r in lr)
                lvRezervimet.Items.Add(new RezervimiListe(r));
        }

        private void btnKerkoAgjension_Click(object sender, EventArgs e)
        {
            Kerko forma = new Kerko();

            if (forma.ShowDialog() == DialogResult.OK)
                VendosiRezervimet(forma.FjalaKyce);
        }

        private void btnFreskoAgjensionet_Click(object sender, EventArgs e)
        {
            VendosiRezervimet("");
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
