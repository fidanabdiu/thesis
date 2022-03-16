using System;
using System.Windows.Forms;
using AgjensioniTuristik.Serveri;
using AgjensioniTuristik.Listat;
using AgjensioniTuristik.FormatBaze;
using AgjensioniTuristik.Veglat;

namespace AgjensioniTuristik.Format
{
    public partial class Fluturimet : EntitetetBaze
    {
        private static Fluturimet instanca = null;
        
        private Fluturimet()
        {
            InitializeComponent();

            VendosiFluturimet();
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

        private void VendosiFluturimet()
        {
            lvFluturimet.Items.Clear();

            WSSoapClient sc = new WSSoapClient();

            foreach (Fluturimi f in sc.FluturimetLexoSipasStatusit(FluturimiAnuluar.JO))
                lvFluturimet.Items.Add(new FluturimiListe(f));
        }

        private void rezervoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvFluturimet.SelectedItems.Count != 0)
            {
                FluturimiListe flvi = (FluturimiListe)lvFluturimet.SelectedItems[0];

                WSSoapClient sc = new WSSoapClient();
                bool ka = sc.LexoUlesetLira(flvi.FluturimiIZgjedhur.Aeroplani.ID, UlesjaEZene.JO);

                if (!ka)
                {
                    MesazhiBaze mesazhi2 = new MesazhiBaze(LlojiMesazhit.Verejtje, "Nuk ka vende të lira", Butonat.Dil);
                    mesazhi2.ShowDialog();
                    return;
                }

                Rezervimi r = new Rezervimi();

                RezervimIRiMeFluturimin forma = new RezervimIRiMeFluturimin(r, flvi.FluturimiIZgjedhur);

                if (forma.ShowDialog() == DialogResult.OK)
                {
                    sc.RezervimiShkruaj(r);

                    MesazhiBaze mesazhi = new MesazhiBaze(LlojiMesazhit.Informacion, "Rezervimi është kryer me sukses", Butonat.Dil);
                    mesazhi.ShowDialog();
                }
            }
        }

        private void btnFreskoFluturimet_Click(object sender, EventArgs e)
        {
            VendosiFluturimet();
        }

        private void nëDetajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvFluturimet.View = View.Details;
        }

        private void vetëmIDjaEFluturimitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvFluturimet.View = View.List;
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
