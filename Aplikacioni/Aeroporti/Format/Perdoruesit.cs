using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aeroporti.Listat;
using BiznesLogjika;
using ShtresaETeDhenave;
using Aeroporti.FormatBaze;
using Aeroporti.Veglat;

namespace Aeroporti.Format
{
    public partial class Perdoruesit : Aeroporti.FormatBaze.EntitetetBaze
    {
        private static Perdoruesit instanca = null;
        
        private Perdoruesit()
        {
            InitializeComponent();
            VendosiPerdoruesit("");
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

        private void VendosiPerdoruesit(string fjalakyce)
        {
            lvPerdoruesit.Items.Clear();

            List<PerdoruesiAeroportit> lp = new List<PerdoruesiAeroportit>();

            PerdoruesitAeroportitDB pdb = new PerdoruesitAeroportitDB(lp);
            pdb.Lexo(fjalakyce);

            foreach (PerdoruesiAeroportit p in lp)
                lvPerdoruesit.Items.Add(new PerdoruesiListe(p));

            Mesazhi("Përdoruesit u vendosën në listë");
        }

        private void VendosePerdoruesin(PerdoruesiAeroportit p)
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

        private void PastrojePerdoruesin()
        {
            pbxFotografia.Image = null;
            lblEmriMbiemri.Text = "";
            lblNumriIdentifikues.Text = "";
            lblDatelindja.Text = "";
            lblVendlindja.Text = "";
            lblVendbanimi.Text = "";
            lblPrivilegji.Text = "";
        }

        private void FshijePerdoruesin()
        {
            lblEmriMbiemri.Text = "";
            lblNumriIdentifikues.Text = "";
            lblDatelindja.Text = "";
            lblVendlindja.Text = "";
            lblVendbanimi.Text = "";
            lblPrivilegji.Text = "";
        }

        private void btnPerdoruesIRi_Click(object sender, EventArgs e)
        {
            PerdoruesiAeroportit p = new PerdoruesiAeroportit();
            PerdoruesIRi forma = new PerdoruesIRi(p);

            if (forma.ShowDialog() == DialogResult.OK)
            {
                PerdoruesiAeroportitDB pdb = new PerdoruesiAeroportitDB(p);
                pdb.Shkruaj();

                lvPerdoruesit.Items.Add(new PerdoruesiListe(p));

                Mesazhi("Përdoruesi u shtua me sukses");
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
                    PerdoruesiAeroportitDB pdb = new PerdoruesiAeroportitDB(plvi.PerdoruesiIZgjedhur);
                    pdb.Ndrysho();

                    plvi.VendosePerdoruesin();

                    Mesazhi("Ndryshimi është kryer me sukses");
                }
            }
        }

        private void btnFshi_Click(object sender, EventArgs e)
        {
            if (lvPerdoruesit.SelectedItems.Count != 0)
            {
                PerdoruesiListe plvi = (PerdoruesiListe)lvPerdoruesit.SelectedItems[0];
                MesazhiBaze mesazhi = new MesazhiBaze(LlojiMesazhit.Verejtje, "A jeni të sigurtë ?", Butonat.OKDil);

                if (mesazhi.ShowDialog() == DialogResult.OK)
                {
                    PerdoruesiAeroportitDB pdb = new PerdoruesiAeroportitDB(plvi.PerdoruesiIZgjedhur);
                    pdb.Fshi();

                    lvPerdoruesit.Items.Remove(plvi);

                    Mesazhi("Fshirja është kryer me sukses");
                }
            }
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            PastrojePerdoruesin();

            Kerko forma = new Kerko();

            if (forma.ShowDialog() == DialogResult.OK)
            {
                VendosiPerdoruesit(forma.FjalaKyce);
            }

            Mesazhi("Filtrimi është kryer me sukses");
        }

        private void lvPerdoruesit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPerdoruesit.SelectedItems.Count != 0)
            {
                PerdoruesiListe plvi = (PerdoruesiListe)lvPerdoruesit.SelectedItems[0];
                VendosePerdoruesin(plvi.PerdoruesiIZgjedhur);
            }
        }

        private void btnFresko_Click(object sender, EventArgs e)
        {
            PastrojePerdoruesin();
            VendosiPerdoruesit("");
        }

        private void nëDetajeToolStripMenuItem1_Click(object sender, EventArgs e)
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
