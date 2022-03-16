using System;
using System.Windows.Forms;
using AgjensioniTuristik.Serveri;
using AgjensioniTuristik.Veglat;

namespace AgjensioniTuristik.Format
{
    public partial class RezervimIRi : FormatBaze.DialoguBaze
    {
        private Rezervimi aRezervimi;
        
        public RezervimIRi(Rezervimi r)
        {
            InitializeComponent();

            aRezervimi = r;

            VendosiFluturimet();
            VendosiUdhetaret();
            VendosiLlojetRezervimeve();
        }

        private void VendoseFluturimin(Fluturimi f)
        {
            lblAeroplani.Text = f.Aeroplani.TipiAeroplanit.Emri + " " + f.Aeroplani.MarkaAeroplanit.Emri;
            lblQyteti.Text = f.Qyteti.Emri;
            lblDataNisjes.Text = f.DataNisjes.ToShortDateString();
            lblOraNisjes.Text = f.OraNisjes.ToShortTimeString();
        }

        private void VendosiLlojetRezervimeve()
        {
            cboLlojetRezervimeve.Items.AddRange(Enum.GetNames(typeof(LlojiIRezervimit)));
        }

        private void VendosiUleset()
        {
            cboUleset.Items.Clear();

            WSSoapClient sc = new WSSoapClient();

            MetodaToString ts = (MetodaToString)cboFluturimet.SelectedItem;
            Fluturimi f = (Fluturimi)ts.Objekti;

            foreach (Ulesja u in sc.UlesetLexoSipasStatusit(f.Aeroplani.ID, UlesjaEZene.JO))
                cboUleset.Items.Add(new MetodaToString(u.Numri.ToString(), u));
        }

        private void VendosiUdhetaret()
        {
            WSSoapClient sc = new WSSoapClient();

            foreach (Udhetari u in sc.UdhetaretLexo(""))
                cboUdhetaret.Items.Add(new MetodaToString(u.Emri + " " + u.Mbiemri, u));
        }

        private void VendosiFluturimet()
        {
            WSSoapClient sc = new WSSoapClient();

            foreach (Fluturimi f in sc.FluturimetLexo(""))
            {
                if(sc.LexoUlesetLira(f.Aeroplani.ID, UlesjaEZene.JO) != false)
                    cboFluturimet.Items.Add(new MetodaToString(f.ID.ToString(), f));
            }
        }

        private void cboLlojetRezervimeve_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLlojetRezervimeve.SelectedItem == null)
                return;

            if(cboFluturimet.SelectedItem == null)
                return;

            LlojiIRezervimit llr = (LlojiIRezervimit)Enum.Parse(typeof(LlojiIRezervimit), cboLlojetRezervimeve.Text);

            MetodaToString ts = (MetodaToString)cboFluturimet.SelectedItem;
            Fluturimi f = (Fluturimi)ts.Objekti;

            if (llr == LlojiIRezervimit.NjeKahesh)
                txtCmimi.Text = f.Cmimi.ToString();
            else
                txtCmimi.Text = f.CmimiKthyes.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cboFluturimet.SelectedItem == null)
            {
                Mesazhi("Zgjedheni fluturimin");
                cboFluturimet.DroppedDown = true;
            }
            else if (cboUdhetaret.SelectedItem == null)
            {
                Mesazhi("Zgjedheni udhëtarin");
                cboUdhetaret.DroppedDown = true;
            }
            else if (cboUleset.SelectedItem == null)
            {
                Mesazhi("Zgjedheni ulësen");
                cboUleset.DroppedDown = true;
            }
            else if (cboLlojetRezervimeve.SelectedItem == null)
            {
                Mesazhi("Zgjedheni llojin e rezervimit");
                cboLlojetRezervimeve.DroppedDown = true;
            }
            else
            {
                aRezervimi.PerdoruesiAgjensionit = Veglat.Veglat.PerdoruesiIKycur;
                
                MetodaToString ts = (MetodaToString)cboFluturimet.SelectedItem;
                aRezervimi.Fluturimi = (Fluturimi)ts.Objekti;

                ts = (MetodaToString)cboUdhetaret.SelectedItem;
                aRezervimi.Udhetari = (Udhetari)ts.Objekti;

                ts = (MetodaToString)cboUleset.SelectedItem;
                Ulesja u = (Ulesja)ts.Objekti;
                u.UlesjaEZene = UlesjaEZene.PO;
                WSSoapClient sc = new WSSoapClient();
                sc.UlesjaNdrysho(u);

                aRezervimi.Ulesja = u;

                aRezervimi.LlojiRezervimit = (LlojiIRezervimit)Enum.Parse(typeof(LlojiIRezervimit), cboLlojetRezervimeve.Text);

                aRezervimi.Cmimi = Convert.ToDecimal(txtCmimi.Text);

                DialogResult = DialogResult.OK;
            }
        }

        private void cboFluturimet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFluturimet.SelectedItem == null)
                return;
            
            VendosiUleset();

            MetodaToString ts = (MetodaToString)cboFluturimet.SelectedItem;
            Fluturimi f = (Fluturimi)ts.Objekti;
            VendoseFluturimin(f);

            lblUleseTeLira.Text = cboUleset.Items.Count.ToString();
        }

        private void btnShtoUdhetar_Click(object sender, EventArgs e)
        {
            Udhetari u = new Udhetari();

            UdhetarIRi forma = new UdhetarIRi(u);

            if (forma.ShowDialog() == DialogResult.OK)
            {
                WSSoapClient sc = new WSSoapClient();
                Udhetari udh = sc.UdhetariShkruaj(u);

                MetodaToString ts = new MetodaToString(udh.Emri + " " + udh.Mbiemri, udh);
                cboUdhetaret.Items.Add(ts);
                cboUdhetaret.SelectedItem = ts;
            }
        }
    }
}
