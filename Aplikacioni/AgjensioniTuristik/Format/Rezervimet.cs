using System;
using System.Windows.Forms;
using AgjensioniTuristik.Serveri;
using AgjensioniTuristik.Listat;
using AgjensioniTuristik.FormatBaze;
using AgjensioniTuristik.Veglat;

namespace AgjensioniTuristik.Format
{
    public partial class Rezervimet : EntitetetBaze
    {
        private static Rezervimet instanca = null;
        
        private Rezervimet()
        {
            InitializeComponent();

            VendosiRezervimet();
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

        private void VendosiRezervimet()
        {
            lvRezervimet.Items.Clear();

            WSSoapClient sc = new WSSoapClient();

            foreach (Rezervimi r in sc.RezervimetLexoSipasAgjensionit(Veglat.Veglat.PerdoruesiIKycur.Agjensioni.ID))
                lvRezervimet.Items.Add(new RezervimiListe(r));
        }

        private void btnShtoRezervim_Click(object sender, EventArgs e)
        {
            Rezervimi r = new Rezervimi();

            RezervimIRi forma = new RezervimIRi(r);

            if (forma.ShowDialog() == DialogResult.OK)
            {
                WSSoapClient sc = new WSSoapClient();
                Rezervimi re = sc.RezervimiShkruaj(r);

                lvRezervimet.Items.Add(new RezervimiListe(re));
            }
        }

        private void btnNdrysho_Click(object sender, EventArgs e)
        {
            if (lvRezervimet.SelectedItems.Count != 0)
            {
                RezervimiListe rlvi = (RezervimiListe)lvRezervimet.SelectedItems[0];

                RezervimIRi forma = new RezervimIRi(rlvi.RezervimiIZgjedhur);

                if (forma.ShowDialog() == DialogResult.OK)
                {
                    WSSoapClient sc = new WSSoapClient();
                    sc.RezervimiNdrysho(rlvi.RezervimiIZgjedhur);

                    rlvi.VendoseRezervimin();
                }
            }
        }

        private void btnFshi_Click(object sender, EventArgs e)
        {
            if (lvRezervimet.SelectedItems.Count != 0)
            {
                RezervimiListe rlvi = (RezervimiListe)lvRezervimet.SelectedItems[0];

                MesazhiBaze forma = new MesazhiBaze(LlojiMesazhit.Verejtje, "A jeni të sigurtë ?", Butonat.OKDil);

                if (forma.ShowDialog() == DialogResult.OK)
                {
                    WSSoapClient sc = new WSSoapClient();
                    sc.RezervimiFshi(rlvi.RezervimiIZgjedhur);

                    Ulesja u = rlvi.RezervimiIZgjedhur.Ulesja;
                    u.UlesjaEZene = UlesjaEZene.JO;

                    sc.UlesjaNdrysho(u);

                    lvRezervimet.Items.Remove(rlvi);
                }
            }
        }

        private void nëDetajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvRezervimet.View = View.Details;
        }

        private void vetëmIDjaERezervimitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvRezervimet.View = View.List;
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
