using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AgjensioniTuristik.Serveri;
using AgjensioniTuristik.Veglat;

namespace AgjensioniTuristik.Format
{
    public partial class RezervimIRiMeFluturimin : FormatBaze.DialoguBaze
    {
        private Rezervimi aRezervimi;
        private Fluturimi aFluturimi;
        
        public RezervimIRiMeFluturimin(Rezervimi r, Fluturimi f)
        {
            InitializeComponent();

            aRezervimi = r;
            aFluturimi = f;

            VendosiUdhetaret();
            VendosiUleset();
            VendosiLlojetRezervimeve();
            VendoseFluturimin();
        }

        private void VendoseFluturimin()
        {
            lblAeroplani.Text = aFluturimi.Aeroplani.TipiAeroplanit.Emri + " " + aFluturimi.Aeroplani.MarkaAeroplanit.Emri;
            lblQyteti.Text = aFluturimi.Qyteti.Emri;
            lblDataNisjes.Text = aFluturimi.DataNisjes.ToShortDateString();
            lblOraNisjes.Text = aFluturimi.OraNisjes.ToShortTimeString();
            lblUleseTeLira.Text = cboUleset.Items.Count.ToString();
        }

        private void VendosiLlojetRezervimeve()
        {
            cboLlojetRezervimeve.Items.AddRange(Enum.GetNames(typeof(LlojiIRezervimit)));
        }

        private void VendosiUleset()
        {
            cboUleset.Items.Clear();
            
            WSSoapClient sc = new WSSoapClient();

            foreach(Ulesja u in sc.UlesetLexoSipasStatusit(aFluturimi.Aeroplani.ID, UlesjaEZene.JO))
                cboUleset.Items.Add(new MetodaToString(u.Numri.ToString(), u));
        }

        private void VendosiUdhetaret()
        {
            WSSoapClient sc = new WSSoapClient();

            foreach (Udhetari u in sc.UdhetaretLexo(""))
                cboUdhetaret.Items.Add(new MetodaToString(u.Emri + " " + u.Mbiemri, u));
        }

        private void cboLlojetRezervimeve_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLlojetRezervimeve.SelectedItem == null)
                return;

            LlojiIRezervimit llr = (LlojiIRezervimit)Enum.Parse(typeof(LlojiIRezervimit), cboLlojetRezervimeve.Text);

            if (llr == LlojiIRezervimit.NjeKahesh)
                txtCmimi.Text = aFluturimi.Cmimi.ToString();
            else
                txtCmimi.Text = aFluturimi.CmimiKthyes.ToString();
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cboUdhetaret.SelectedItem == null)
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
            else if (txtCmimi.Text.Length == 0)
            {
                Mesazhi("Shkruajeni çmimin");
                txtCmimi.Focus();
            }
            else
            {
                aRezervimi.Fluturimi = aFluturimi;

                MetodaToString ts = (MetodaToString)cboUdhetaret.SelectedItem;
                aRezervimi.Udhetari = (Udhetari)ts.Objekti;

                ts = (MetodaToString)cboUleset.SelectedItem;
                aRezervimi.Ulesja = (Ulesja)ts.Objekti;

                aRezervimi.LlojiRezervimit = (LlojiIRezervimit)Enum.Parse(typeof(LlojiIRezervimit), cboLlojetRezervimeve.Text);
                aRezervimi.Cmimi = Convert.ToDecimal(txtCmimi.Text);

                aRezervimi.PerdoruesiAgjensionit = Veglat.Veglat.PerdoruesiIKycur;

                ts = (MetodaToString)cboUleset.SelectedItem;
                Ulesja u = (Ulesja)ts.Objekti;
                u.UlesjaEZene = UlesjaEZene.PO;
                WSSoapClient sc = new WSSoapClient();
                sc.UlesjaNdrysho(u);

                DialogResult = DialogResult.OK;
            }
        }
    }
}
