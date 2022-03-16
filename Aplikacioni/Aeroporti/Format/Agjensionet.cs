using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BiznesLogjika;
using ShtresaETeDhenave;
using Aeroporti.Listat;
using Aeroporti.FormatBaze;
using Aeroporti.Veglat;

namespace Aeroporti.Format
{
    public partial class Agjensionet : FormatBaze.EntitetetBaze
    {
        private static Agjensionet instanca = null;
        
        private Agjensionet()
        {
            InitializeComponent();

            VendosiAgjensionet("");
            VendosiPerdoruesit("");
        }

        public static Agjensionet MerreInstancen()
        {
            if (instanca == null)
            {
                instanca = new Agjensionet();
                return instanca;
            }
            else
                return instanca;
        }

        private void VendosiPerdoruesit(string fjalakyce)
        {
            lvPerdoruesit.Items.Clear();

            List<PerdoruesiAgjensionit> lpa = new List<PerdoruesiAgjensionit>();

            PerdoruesitAgjensionitDB padb = new PerdoruesitAgjensionitDB(lpa);
            padb.Lexo(fjalakyce);

            foreach (PerdoruesiAgjensionit pa in lpa)
                lvPerdoruesit.Items.Add(new PerdoruesiAgjensionitListe(pa));
        }

        private void VendosiAgjensionet(string fjalakyce)
        {
            lsAgjensionet.Items.Clear();

            List<Agjensioni> la = new List<Agjensioni>();

            AgjensionetDB adb = new AgjensionetDB(la);
            adb.Lexo(fjalakyce);

            foreach (Agjensioni a in la)
                lsAgjensionet.Items.Add(a);
        }

        private void btnShtoAgjension_Click(object sender, EventArgs e)
        {
            Agjensioni a = new Agjensioni();

            AgjensionIRi forma = new AgjensionIRi(a);

            if (forma.ShowDialog() == DialogResult.OK)
            {
                AgjensioniDB adb = new AgjensioniDB(a);
                adb.Shkruaj();

                lsAgjensionet.Items.Add(a);
            }
        }

        private void btnNdryshoAgjension_Click(object sender, EventArgs e)
        {
            if (lsAgjensionet.SelectedItems.Count != 0)
            {
                Agjensioni a = (Agjensioni)lsAgjensionet.SelectedItem;

                AgjensionIRi forma = new AgjensionIRi(a);

                if (forma.ShowDialog() == DialogResult.OK)
                {
                    lsAgjensionet.Items.Remove(a);

                    AgjensioniDB adb = new AgjensioniDB(a);
                    adb.Ndrysho();

                    lsAgjensionet.Items.Add(a);
                }
            }
        }

        private void btnFshiAgjension_Click(object sender, EventArgs e)
        {
            if (lsAgjensionet.SelectedItems.Count != 0)
            {
                Agjensioni a = (Agjensioni)lsAgjensionet.SelectedItem;

                MesazhiBaze forma = new MesazhiBaze(LlojiMesazhit.Verejtje, "A jeni të sigurtë ?", Butonat.OKDil);

                if (forma.ShowDialog() == DialogResult.OK)
                {
                    AgjensioniDB adb = new AgjensioniDB(a);
                    adb.Fshi();

                    lsAgjensionet.Items.Remove(a);
                }
            }
        }

        private void btnKerkoAgjension_Click(object sender, EventArgs e)
        {
            Kerko forma = new Kerko();

            if (forma.ShowDialog() == DialogResult.OK)
            {
                VendosiAgjensionet(forma.FjalaKyce);
            }
        }

        private void btnFreskoAgjensionet_Click(object sender, EventArgs e)
        {
            VendosiAgjensionet("");
        }

        private void btnShtoPerdorues_Click(object sender, EventArgs e)
        {
            PerdoruesiAgjensionit pa = new PerdoruesiAgjensionit();

            PerdoruesIRiAgjensionit forma = new PerdoruesIRiAgjensionit(pa);

            if (forma.ShowDialog() == DialogResult.OK)
            {
                PerdoruesiAgjensionitDB padb = new PerdoruesiAgjensionitDB(pa);
                padb.Shkruaj();

                lvPerdoruesit.Items.Add(new PerdoruesiAgjensionitListe(pa));
            }
        }

        private void btnNdryshoPerdorues_Click(object sender, EventArgs e)
        {
            if (lvPerdoruesit.SelectedItems.Count != 0)
            {
                PerdoruesiAgjensionitListe palvi = (PerdoruesiAgjensionitListe)lvPerdoruesit.SelectedItems[0];

                PerdoruesIRiAgjensionit forma = new PerdoruesIRiAgjensionit(palvi.PerdoruesiIZgjedhur);

                if (forma.ShowDialog() == DialogResult.OK)
                {
                    PerdoruesiAgjensionitDB padb = new PerdoruesiAgjensionitDB(palvi.PerdoruesiIZgjedhur);
                    padb.Ndrysho();

                    palvi.VendosePerdoruesin();
                }
            }
        }

        private void btnFshiPerdorues_Click(object sender, EventArgs e)
        {
            if (lvPerdoruesit.SelectedItems.Count != 0)
            {
                PerdoruesiAgjensionitListe palvi = (PerdoruesiAgjensionitListe)lvPerdoruesit.SelectedItems[0];

                MesazhiBaze forma = new MesazhiBaze(LlojiMesazhit.Verejtje, "A jeni të sigurtë ?", Butonat.OKDil);

                if (forma.ShowDialog() == DialogResult.OK)
                {
                    PerdoruesiAgjensionitDB padb = new PerdoruesiAgjensionitDB(palvi.PerdoruesiIZgjedhur);
                    padb.Fshi();

                    lvPerdoruesit.Items.Remove(palvi);
                }
            }
        }

        private void btnKerkoPerdoruesit_Click(object sender, EventArgs e)
        {
            Kerko forma = new Kerko();

            if (forma.ShowDialog() == DialogResult.OK)
            {
                VendosiPerdoruesit(forma.FjalaKyce);
            }
        }

        private void btnFreskoPerdoruesit_Click(object sender, EventArgs e)
        {
            VendosiPerdoruesit("");
        }

        private void lsAgjensionet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsAgjensionet.SelectedItems.Count != 0)
            {
                lvPerdoruesit.Items.Clear();

                Agjensioni a = (Agjensioni)lsAgjensionet.SelectedItem;

                List<PerdoruesiAgjensionit> lpa = new List<PerdoruesiAgjensionit>();

                PerdoruesitAgjensionitDB padb = new PerdoruesitAgjensionitDB(lpa);
                padb.Lexo(a.ID);

                foreach (PerdoruesiAgjensionit pa in lpa)
                    lvPerdoruesit.Items.Add(new PerdoruesiAgjensionitListe(pa));
            }
        }

        private void nëDetajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvPerdoruesit.View = View.Details;
        }

        private void vetëmEmriDheMbiemriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvPerdoruesit.View = View.List;
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
