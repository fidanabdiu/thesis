using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Aeroporti.FormatBaze;
using BiznesLogjika;
using ShtresaETeDhenave;
using Aeroporti.Listat;
using Aeroporti.Veglat;

namespace Aeroporti.Format
{
    public partial class Shtetet : EntitetetBaze
    {
        private static Shtetet instanca = null;
        
        private Shtetet()
        {
            InitializeComponent();

            VendosiShtetet("");
            VendosiQytetet("");
        }

        public static Shtetet MerreInstancen()
        {
            if (instanca == null)
            {
                instanca = new Shtetet();
                return instanca;
            }
            else
                return instanca;
        }

        private void VendosiQytetet(string s)
        {
            lvQytetet.Items.Clear();
            
            List<Qyteti> lq = new List<Qyteti>();

            QytetetDB qdb = new QytetetDB(lq);
            qdb.Lexo(s);

            foreach (Qyteti q in lq)
                lvQytetet.Items.Add(new QytetiListe(q));                
        }

        private void VendosiShtetet(string s)
        {
            lvShtetet.Items.Clear();
            
            List<Shteti> lsh = new List<Shteti>();

            ShtetetDB shdb = new ShtetetDB(lsh);
            shdb.Lexo(s);

            foreach(Shteti sh in lsh)
                lvShtetet.Items.Add(new ShtetiListe(sh));
        }

        private void btnShtoShtet_Click(object sender, EventArgs e)
        {
            Shteti sh = new Shteti();

            ShtetIRi forma = new ShtetIRi(sh);

            if (forma.ShowDialog() == DialogResult.OK)
            {
                ShtetiDB shdb = new ShtetiDB(sh);
                shdb.Shkruaj();

                lvShtetet.Items.Add(new ShtetiListe(sh));
            }
        }

        private void btShtoQytet_Click(object sender, EventArgs e)
        {
            Qyteti q = new Qyteti();

            QytetIRi forma = new QytetIRi(q);

            if (forma.ShowDialog() == DialogResult.OK)
            {
                QytetiDB qdb = new QytetiDB(q);
                qdb.Shkruaj();

                lvQytetet.Items.Add(new QytetiListe(q));
            }
        }

        private void btnNdryshoShtet_Click(object sender, EventArgs e)
        {
            if (lvShtetet.SelectedItems.Count != 0)
            {
                ShtetiListe shlvi = (ShtetiListe)lvShtetet.SelectedItems[0];

                ShtetIRi forma = new ShtetIRi(shlvi.ShtetiIZgjedhur);

                if (forma.ShowDialog() == DialogResult.OK)
                {
                    ShtetiDB shdb = new ShtetiDB(shlvi.ShtetiIZgjedhur);
                    shdb.Ndrysho();

                    shlvi.VendoseShtetin();
                }
            }
        }

        private void btnFshiShtet_Click(object sender, EventArgs e)
        {
            if (lvShtetet.SelectedItems.Count != 0)
            {
                ShtetiListe shlvi = (ShtetiListe)lvShtetet.SelectedItems[0];

                MesazhiBaze mesazhi = new MesazhiBaze(LlojiMesazhit.Verejtje, "A jeni të sigurtë ?", Butonat.OKDil);

                if (mesazhi.ShowDialog() == DialogResult.OK)
                {
                    ShtetiDB shdb = new ShtetiDB(shlvi.ShtetiIZgjedhur);
                    shdb.Fshi();

                    lvShtetet.Items.Remove(shlvi);
                }
            }
        }

        private void btnNdryshoQytet_Click(object sender, EventArgs e)
        {
            if (lvQytetet.SelectedItems.Count != 0)
            {
                QytetiListe qlvi = (QytetiListe)lvQytetet.SelectedItems[0];

                QytetIRi forma = new QytetIRi(qlvi.QytetiIZgjedhur);

                if (forma.ShowDialog() == DialogResult.OK)
                {
                    QytetiDB qdb = new QytetiDB(qlvi.QytetiIZgjedhur);
                    qdb.Ndrysho();

                    qlvi.VendoseQytetin();
                }
            }
        }

        private void btnFshiQytet_Click(object sender, EventArgs e)
        {
            if (lvQytetet.SelectedItems.Count != 0)
            {
                QytetiListe qlvi = (QytetiListe)lvQytetet.SelectedItems[0];

                MesazhiBaze mesazhi = new MesazhiBaze(LlojiMesazhit.Verejtje, "A jeni të sigurtë ?", Butonat.OKDil);

                if (mesazhi.ShowDialog() == DialogResult.OK)
                {
                    QytetiDB qdb = new QytetiDB(qlvi.QytetiIZgjedhur);
                    qdb.Fshi();

                    lvQytetet.Items.Remove(qlvi);
                }
            }
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            Kerko forma = new Kerko();

            if (forma.ShowDialog() == DialogResult.OK)
            {
                VendosiShtetet(forma.FjalaKyce);
            }
        }

        private void btnFiltroQytetet_Click(object sender, EventArgs e)
        {
            Kerko forma = new Kerko();

            if (forma.ShowDialog() == DialogResult.OK)
            {
                VendosiQytetet(forma.FjalaKyce);
            }
        }

        private void listaEQyteteveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvShtetet.SelectedItems.Count != 0)
            {
                ShtetiListe shlvi = (ShtetiListe)lvShtetet.SelectedItems[0];

                List<Qyteti> lq = new List<Qyteti>();

                QytetetDB qdb = new QytetetDB(lq);
                qdb.Lexo(shlvi.ShtetiIZgjedhur.ID);

                QytetetSipasShtetit forma = new QytetetSipasShtetit(lq);
                forma.ShowDialog();
            }
        }

        private void btnFreskoShtetet_Click(object sender, EventArgs e)
        {
            VendosiShtetet("");
        }

        private void btnFreskoQytetet_Click(object sender, EventArgs e)
        {
            VendosiQytetet("");
        }

        private void nëDetajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvQytetet.View = View.Details;
        }

        private void vetëmQytetiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvQytetet.View = View.List;
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
