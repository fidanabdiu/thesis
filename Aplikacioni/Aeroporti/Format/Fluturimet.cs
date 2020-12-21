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
using Aeroporti.FormatBaze;
using Aeroporti.Veglat;

namespace Aeroporti.Format
{
    public partial class Fluturimet : FormatBaze.EntitetetBaze
    {
        private static Fluturimet instanca = null;
        
        private Fluturimet()
        {
            InitializeComponent();

            VendosiFluturimet("");
        }

        public static Fluturimet MerreInstancen()
        {
            if (instanca == null)
            {
                instanca = new Fluturimet();
                return instanca;
            }
            else
                return instanca;
        }

        private void VendosiFluturimet(string fjalakyce)
        {
            lvFluturimet.Items.Clear();

            List<Fluturimi> lf = new List<Fluturimi>();

            FluturimetDB fdb = new FluturimetDB(lf);
            fdb.Lexo(fjalakyce);

            foreach (Fluturimi f in lf)
                lvFluturimet.Items.Add(new FluturimiListe(f));
        }

        private void btnShtoFluturim_Click(object sender, EventArgs e)
        {
            Fluturimi f = new Fluturimi();

            FluturimIRi forma = new FluturimIRi(f);

            if (forma.ShowDialog() == DialogResult.OK)
            {
                FluturimiDB fdb = new FluturimiDB(f);
                fdb.Shkruaj();

                lvFluturimet.Items.Add(new FluturimiListe(f));
            }
        }

        private void btnNdryshoFluturim_Click(object sender, EventArgs e)
        {
            if (lvFluturimet.SelectedItems.Count != 0)
            {
                FluturimiListe flvi = (FluturimiListe)lvFluturimet.SelectedItems[0];

                FluturimIRi forma = new FluturimIRi(flvi.FluturimiIZgjedhur);

                if (forma.ShowDialog() == DialogResult.OK)
                {
                    FluturimiDB fdb = new FluturimiDB(flvi.FluturimiIZgjedhur);
                    fdb.Ndrysho();

                    flvi.VendoseFluturimin();
                }
            }
        }

        private void btnFshiFluturim_Click(object sender, EventArgs e)
        {
            if (lvFluturimet.SelectedItems.Count != 0)
            {
                FluturimiListe flvi = (FluturimiListe)lvFluturimet.SelectedItems[0];

                MesazhiBaze forma = new MesazhiBaze(LlojiMesazhit.Verejtje, "A jeni të sigurtë ?", Butonat.OKDil);

                if (forma.ShowDialog() == DialogResult.OK)
                {
                    FluturimiDB fdb = new FluturimiDB(flvi.FluturimiIZgjedhur);
                    fdb.Fshi();

                    lvFluturimet.Items.Remove(flvi);
                }
            }
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            Kerko forma = new Kerko();

            if (forma.ShowDialog() == DialogResult.OK)
            {
                VendosiFluturimet(forma.FjalaKyce);
            }
        }

        private void btnFreskoFluturimet_Click(object sender, EventArgs e)
        {
            VendosiFluturimet("");
        }

        private void nëDetajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvFluturimet.View = View.Details;
        }

        private void vetëmNumriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvFluturimet.View = View.List;
        }

        private void anuloFluturiminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvFluturimet.SelectedItems.Count != 0)
            {
                FluturimiListe flvi = (FluturimiListe)lvFluturimet.SelectedItems[0];

                MesazhiBaze forma = new MesazhiBaze(LlojiMesazhit.Verejtje, "A jeni të sigurtë ?", Butonat.OKDil);

                if (forma.ShowDialog() == DialogResult.OK)
                {
                    flvi.FluturimiIZgjedhur.FluturimiAnuluar = FluturimiAnuluar.PO;

                    FluturimiDB fdb = new FluturimiDB(flvi.FluturimiIZgjedhur);
                    fdb.Ndrysho();

                    flvi.VendoseFluturimin();

                    MesazhiBaze forma2 = new MesazhiBaze(LlojiMesazhit.Informacion, "Fluturimi është anuluar me sukses", Butonat.Dil);
                    forma2.ShowDialog();
                }
            }
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
