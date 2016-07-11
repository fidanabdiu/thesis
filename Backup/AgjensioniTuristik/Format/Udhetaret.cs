using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AgjensioniTuristik.Serveri;
using AgjensioniTuristik.Listat;
using AgjensioniTuristik.FormatBaze;
using AgjensioniTuristik.Veglat;

namespace AgjensioniTuristik.Format
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

            WSSoapClient sc = new WSSoapClient();

            foreach (Udhetari u in sc.UdhetaretLexo(fjalakyce))
                lvUdhetaret.Items.Add(new UdhetariListe(u));
        }

        private void btnShtoUdhetar_Click(object sender, EventArgs e)
        {
            Udhetari u = new Udhetari();

            UdhetarIRi forma = new UdhetarIRi(u);

            if (forma.ShowDialog() == DialogResult.OK)
            {
                WSSoapClient sc = new WSSoapClient();
                sc.UdhetariShkruaj(u);

                lvUdhetaret.Items.Add(new UdhetariListe(u));
            }
        }

        private void btnNdrysho_Click(object sender, EventArgs e)
        {
            if (lvUdhetaret.SelectedItems.Count != 0)
            {
                UdhetariListe ulvi = (UdhetariListe)lvUdhetaret.SelectedItems[0];

                if (ulvi.UdhetariIZgjedhur.PerdoruesiAgjensionit.Agjensioni.ID != Veglat.Veglat.PerdoruesiIKycur.Agjensioni.ID)
                {
                    MesazhiBaze mesazhi = new MesazhiBaze(LlojiMesazhit.Gabim, "Nuk mund t'i ndryshoni të dhënat e udhëtarit", Butonat.Dil);
                    mesazhi.ShowDialog();
                    return;
                }

                UdhetarIRi forma = new UdhetarIRi(ulvi.UdhetariIZgjedhur);

                if (forma.ShowDialog() == DialogResult.OK)
                {
                    WSSoapClient sc = new WSSoapClient();
                    sc.UdhetariNdrysho(ulvi.UdhetariIZgjedhur);

                    ulvi.VendoseUdhetarin();
                }
            }
        }

        private void btnFshi_Click(object sender, EventArgs e)
        {
            if (lvUdhetaret.SelectedItems.Count != 0)
            {
                UdhetariListe ulvi = (UdhetariListe)lvUdhetaret.SelectedItems[0];

                if (ulvi.UdhetariIZgjedhur.PerdoruesiAgjensionit.Agjensioni.ID != Veglat.Veglat.PerdoruesiIKycur.Agjensioni.ID)
                {
                    MesazhiBaze mesazhi = new MesazhiBaze(LlojiMesazhit.Gabim, "Nuk mund të fshihet udhëtari", Butonat.Dil);
                    mesazhi.ShowDialog();
                    return;
                }

                MesazhiBaze forma = new MesazhiBaze(LlojiMesazhit.Verejtje, "A jeni të sigurtë ?", Butonat.OKDil);

                if (forma.ShowDialog() == DialogResult.OK)
                {
                    WSSoapClient sc = new WSSoapClient();
                    sc.UdhetariFshi(ulvi.UdhetariIZgjedhur);

                    lvUdhetaret.Items.Remove(ulvi);
                }
            }
        }

        private void btnKerkoUdhetar_Click(object sender, EventArgs e)
        {
            Kerko forma = new Kerko();

            if (forma.ShowDialog() == DialogResult.OK)
                VendosiUdhetaret(forma.FjalaKyce);
        }

        private void btnFresko_Click(object sender, EventArgs e)
        {
            VendosiUdhetaret("");
        }

        private void nëDetajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvUdhetaret.View = View.Details;
        }

        private void vetëmEmriDheMbiemriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvUdhetaret.View = View.List;
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
