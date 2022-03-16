using System;
using System.Windows.Forms;
using AgjensioniTuristik.Serveri;
using AgjensioniTuristik.Listat;
using AgjensioniTuristik.FormatBaze;
using AgjensioniTuristik.Veglat;

namespace AgjensioniTuristik.Format
{
    public partial class Perdoruesit : EntitetetBaze
    {
        private static Perdoruesit instanca = null;
        
        private Perdoruesit()
        {
            InitializeComponent();

            VendosiPerdoruesi();
        }

        public static Perdoruesit MerreInstancen()
        {
            if (instanca == null)
            {
                instanca = new Perdoruesit();
                return instanca;
            }
            else
                return instanca;
        }

        private void VendosiPerdoruesi()
        {
            lvPerdoruesit.Items.Clear();

            WSSoapClient sc = new WSSoapClient();

            foreach(PerdoruesiAgjensionit pa in sc.PerdoruesiAgjensionitLexoSipasAgjensionit(Veglat.Veglat.PerdoruesiIKycur.Agjensioni.ID))
                lvPerdoruesit.Items.Add(new PerdoruesiListe(pa));
        }

        private void btnPerdoruesIRi_Click(object sender, EventArgs e)
        {
            PerdoruesiAgjensionit pa = new PerdoruesiAgjensionit();

            PerdoruesIRi forma = new PerdoruesIRi(pa);

            if (forma.ShowDialog() == DialogResult.OK)
            {
                WSSoapClient sc = new WSSoapClient();
                sc.PerdoruesiAgjensionitShkruaj(pa);

                lvPerdoruesit.Items.Add(new PerdoruesiListe(pa));
            }
        }

        private void btnNdrysho_Click(object sender, EventArgs e)
        {
            if (lvPerdoruesit.SelectedItems.Count != 0)
            {
                PerdoruesiListe plvi = (PerdoruesiListe)lvPerdoruesit.SelectedItems[0];

                PerdoruesIRi forma = new PerdoruesIRi(plvi.PerdoruesiIZgjedhur);

                if (forma.ShowDialog() == DialogResult.OK)
                {
                    WSSoapClient sc = new WSSoapClient();
                    sc.PerdoruesiAgjensionitNdrysho(plvi.PerdoruesiIZgjedhur);

                    plvi.VendosePerdoruesin();
                }
            }
        }

        private void btnFshi_Click(object sender, EventArgs e)
        {
            if (lvPerdoruesit.SelectedItems.Count != 0)
            {
                PerdoruesiListe plvi = (PerdoruesiListe)lvPerdoruesit.SelectedItems[0];

                MesazhiBaze forma = new MesazhiBaze(LlojiMesazhit.Verejtje, "A jeni të sigurtë ?", Butonat.OKDil);

                if (forma.ShowDialog() == DialogResult.OK)
                {
                    WSSoapClient sc = new WSSoapClient();
                    sc.PerdoruesiAgjensionitFshi(plvi.PerdoruesiIZgjedhur);

                    lvPerdoruesit.Items.Remove(plvi);
                }
            }
        }

        private void VendosePerdoruesin(PerdoruesiAgjensionit p)
        {
            if (p.Emri == "Fidan")
                pbxFotografia.Image = imageList1.Images[0];
            else
                pbxFotografia.Image = null;

            lblEmriMbiemri.Text = p.Emri + " " + p.Mbiemri;
            lblNumriIdentifikues.Text = p.NumriIdentifikues;
            lblDatelindja.Text = p.Datelindja.ToShortDateString();
            lblVendlindja.Text = p.Vendlindja;
            lblVendbanimi.Text = p.Vendbanimi;
            lblPrivilegji.Text = p.Privilegji.ToString();
        }

        private void lvPerdoruesit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPerdoruesit.SelectedItems.Count != 0)
            {
                PerdoruesiListe plvi = (PerdoruesiListe)lvPerdoruesit.SelectedItems[0];

                VendosePerdoruesin(plvi.PerdoruesiIZgjedhur);
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
