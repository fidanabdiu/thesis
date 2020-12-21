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
    public partial class LinjatAjrore : FormatBaze.EntitetetBaze
    {
        private static LinjatAjrore instanca = null;
        
        private LinjatAjrore()
        {
            InitializeComponent();

            VendosiLinjatAjrore("");
            VendosiAeroplanat("");
        }

        public static LinjatAjrore MerreInstancen()
        {
            if (instanca == null)
            {
                instanca = new LinjatAjrore();
                return instanca;
            }
            else
                return instanca;
        }

        private void VendosiAeroplanat(string fjalakyce)
        {
            lvAeroplanat.Items.Clear();

            List<Aeroplani> la = new List<Aeroplani>();

            AeroplanatDB adb = new AeroplanatDB(la);
            adb.Lexo(fjalakyce);

            foreach (Aeroplani a in la)
                lvAeroplanat.Items.Add(new AeroplaniListe(a));
        }

        private void VendosiLinjatAjrore(string fjalakyce)
        {
            lvLinjat.Items.Clear();

            List<LinjaAjrore> lla = new List<LinjaAjrore>();

            LinjatAjroreDB ladb = new LinjatAjroreDB(lla);
            ladb.Lexo(fjalakyce);

            foreach (LinjaAjrore la in lla)
                lvLinjat.Items.Add(new LinjaAjroreListe(la));
        }

        private void btnShtoLinje_Click(object sender, EventArgs e)
        {
            LinjaAjrore la = new LinjaAjrore();

            LinjeERe forma = new LinjeERe(la);

            if (forma.ShowDialog() == DialogResult.OK)
            {
                LinjaAjroreDB ladb = new LinjaAjroreDB(la);
                ladb.Shkruaj();

                lvLinjat.Items.Add(new LinjaAjroreListe(la));
            }
        }

        private void btnNdryshoLinje_Click(object sender, EventArgs e)
        {
            if (lvLinjat.SelectedItems.Count != 0)
            {
                LinjaAjroreListe lalvi = (LinjaAjroreListe)lvLinjat.SelectedItems[0];

                LinjeERe forma = new LinjeERe(lalvi.LinjaEZgjedhur);

                if (forma.ShowDialog() == DialogResult.OK)
                {
                    LinjaAjroreDB ladb = new LinjaAjroreDB(lalvi.LinjaEZgjedhur);
                    ladb.Ndrysho();

                    lalvi.VendoseLinjenAjrore();
                }
            }
        }

        private void btnFshiLinje_Click(object sender, EventArgs e)
        {
            if (lvLinjat.SelectedItems.Count != 0)
            {
                LinjaAjroreListe lalvi = (LinjaAjroreListe)lvLinjat.SelectedItems[0];

                MesazhiBaze forma = new MesazhiBaze(LlojiMesazhit.Verejtje, "A jeni të sigurtë ?", Butonat.OKDil);

                if (forma.ShowDialog() == DialogResult.OK)
                {
                    LinjaAjroreDB ladb = new LinjaAjroreDB(lalvi.LinjaEZgjedhur);
                    ladb.Fshi();

                    lvLinjat.Items.Remove(lalvi);
                }
            }
        }

        private void btnKerkoLinje_Click(object sender, EventArgs e)
        {
            Kerko forma = new Kerko();

            if (forma.ShowDialog() == DialogResult.OK)
            {
                VendosiLinjatAjrore(forma.FjalaKyce);
            }
        }

        private void btnFreskoLinjat_Click(object sender, EventArgs e)
        {
            VendosiLinjatAjrore("");
        }

        private void btnShtoAeroplan_Click(object sender, EventArgs e)
        {
            Aeroplani a = new Aeroplani();

            AeroplanIRi forma = new AeroplanIRi(a);

            if (forma.ShowDialog() == DialogResult.OK)
            {
                AeroplaniDB adb = new AeroplaniDB(a);
                adb.Shkruaj();

                lvAeroplanat.Items.Add(new AeroplaniListe(a));

                Ulesja u;
                UlesjaDB udb;
                for (int i = 1; i <= a.NumriUleseve; i++)
                {
                    u = new Ulesja();
                    u.Numri = i;
                    u.Aeroplani = a;

                    udb = new UlesjaDB(u);
                    udb.Shkruaj();
                }
            }
        }

        private void btnNdryshoAeroplan_Click(object sender, EventArgs e)
        {
            if (lvAeroplanat.SelectedItems.Count != 0)
            {
                AeroplaniListe alvi = (AeroplaniListe)lvAeroplanat.SelectedItems[0];

                AeroplanIRi forma = new AeroplanIRi(alvi.AeroplaniIZgjedhur);

                if (forma.ShowDialog() == DialogResult.OK)
                {
                    AeroplaniDB adb = new AeroplaniDB(alvi.AeroplaniIZgjedhur);
                    adb.Ndrysho();

                    alvi.VendoseAeroplanin();

                    Ulesja u;
                    UlesjaDB udb;
                    for (int i = 1; i <= alvi.AeroplaniIZgjedhur.NumriUleseve; i++)
                    {
                        u = new Ulesja();
                        u.Numri = i;
                        u.Aeroplani = alvi.AeroplaniIZgjedhur;

                        udb = new UlesjaDB(u);
                        udb.Shkruaj();
                    }
                }
            }
        }

        private void btnFshiAeroplan_Click(object sender, EventArgs e)
        {
            if (lvAeroplanat.SelectedItems.Count != 0)
            {
                AeroplaniListe alvi = (AeroplaniListe)lvAeroplanat.SelectedItems[0];

                MesazhiBaze forma = new MesazhiBaze(LlojiMesazhit.Verejtje, "A jeni të sigurtë ?", Butonat.OKDil);

                if (forma.ShowDialog() == DialogResult.OK)
                {
                    AeroplaniDB adb = new AeroplaniDB(alvi.AeroplaniIZgjedhur);
                    adb.Fshi();

                    lvAeroplanat.Items.Remove(alvi);
                }
            }
        }

        private void btnKerkoAeroplan_Click(object sender, EventArgs e)
        {
            Kerko forma = new Kerko();

            if (forma.ShowDialog() == DialogResult.OK)
            {
                VendosiAeroplanat(forma.FjalaKyce);
            }
        }

        private void btnFreskoAeroplanat_Click(object sender, EventArgs e)
        {
            VendosiAeroplanat("");
        }

        private void nëDetajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvAeroplanat.View = View.Details;
        }

        private void vetëmNumriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvAeroplanat.View = View.List;
        }

        private void listaEAeroplanaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvLinjat.SelectedItems.Count != 0)
            {
                LinjaAjroreListe lalvi = (LinjaAjroreListe)lvLinjat.SelectedItems[0];

                List<Aeroplani> la = new List<Aeroplani>();

                AeroplanatDB adb = new AeroplanatDB(la);
                adb.Lexo(lalvi.LinjaEZgjedhur.ID);

                AeroplanatSipasLinjesAjrore forma = new AeroplanatSipasLinjesAjrore(la);
                forma.ShowDialog();
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
