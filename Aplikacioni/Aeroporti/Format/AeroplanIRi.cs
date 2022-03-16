using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BiznesLogjika;
using ShtresaETeDhenave;

namespace Aeroporti.Format
{
    public partial class AeroplanIRi : FormatBaze.DialoguBaze
    {
        private Aeroplani aAeroplani;
        
        public AeroplanIRi(Aeroplani a)
        {
            InitializeComponent();

            aAeroplani = a;

            VendosiLinjatAjrore();
            VendosiTipetAeroplanave();
            VendosiMarkatAeroplanave();
        }

        private void VendosiMarkatAeroplanave()
        {
            List<MarkaAeroplanit> lma = new List<MarkaAeroplanit>();

            MarkatAeroplanaveDB madb = new MarkatAeroplanaveDB(lma);
            madb.Lexo("");

            foreach (MarkaAeroplanit ma in lma)
                cboMarkaAeroplanit.Items.Add(ma);
        }

        private void VendosiTipetAeroplanave()
        {
            List<TipiAeroplanit> lta = new List<TipiAeroplanit>();

            TipetAeroplanaveDB tadb = new TipetAeroplanaveDB(lta);
            tadb.Lexo("");

            foreach (TipiAeroplanit ta in lta)
                cboTipiAeroplanit.Items.Add(ta);
        }

        private void VendosiLinjatAjrore()
        {
            List<LinjaAjrore> lla = new List<LinjaAjrore>();

            LinjatAjroreDB ladb = new LinjatAjroreDB(lla);
            ladb.Lexo("");

            foreach (LinjaAjrore la in lla)
                cboLinjat.Items.Add(la);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cboLinjat.SelectedItem == null)
            {
                Mesazhi("Zgjedheni linjën ajrore");
                cboLinjat.DroppedDown = true;
            }
            else if (cboTipiAeroplanit.SelectedItem == null)
            {
                Mesazhi("Zgjedheni tipin e aeroplanit");
                cboTipiAeroplanit.DroppedDown = true;
            }
            else if (cboMarkaAeroplanit.SelectedItem == null)
            {
                Mesazhi("Zgjedheni markën e aeroplanit");
                cboMarkaAeroplanit.DroppedDown = true;
            }
            else if (txtNumriUleseve.Text.Length == 0)
            {
                Mesazhi("Shkruajeni numrin e ulëseve");
            }
            else
            {
                if (Convert.ToInt64(txtNumriUleseve.Text) < 100 || Convert.ToInt64(txtNumriUleseve.Text) > 400)
                    Mesazhi("Numri i ulëseve duhet të jetë ndërmjet 100 dhe 400");
                else
                {
                    aAeroplani.LinjaAjrore = (LinjaAjrore)cboLinjat.SelectedItem;
                    aAeroplani.TipiAeroplanit = (TipiAeroplanit)cboTipiAeroplanit.SelectedItem;
                    aAeroplani.MarkaAeroplanit = (MarkaAeroplanit)cboMarkaAeroplanit.SelectedItem;
                    aAeroplani.NumriUleseve = Convert.ToInt16(txtNumriUleseve.Text);

                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LinjaAjrore la = new LinjaAjrore();

            LinjeERe forma = new LinjeERe(la);

            if (forma.ShowDialog() == DialogResult.OK)
            {
                LinjaAjroreDB ladb = new LinjaAjroreDB(la);
                ladb.Shkruaj();

                cboLinjat.Items.Add(la);
                cboLinjat.SelectedItem = la;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TipiAeroplanit ta = new TipiAeroplanit();

            TipIRi forma = new TipIRi(ta);

            if (forma.ShowDialog() == DialogResult.OK)
            {
                TipiAeroplanitDB tadb = new TipiAeroplanitDB(ta);
                tadb.Shkruaj();

                cboTipiAeroplanit.Items.Add(ta);
                cboTipiAeroplanit.SelectedItem = ta;
            }
        }

        private void cboTipiAeroplanit_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMarkaAeroplanit.Items.Clear();

            List<MarkaAeroplanit> lma = new List<MarkaAeroplanit>();

            MarkatAeroplanaveDB madb = new MarkatAeroplanaveDB(lma);
            madb.Lexo(((TipiAeroplanit)cboTipiAeroplanit.SelectedItem).ID);

            foreach (MarkaAeroplanit ma in lma)
                cboMarkaAeroplanit.Items.Add(ma);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cboTipiAeroplanit.SelectedItem == null)
                return;
            
            MarkaAeroplanit ma = new MarkaAeroplanit();

            MarkeERe forma = new MarkeERe(ma);

            if (forma.ShowDialog() == DialogResult.OK)
            {
                ma.TipiAeroplanit = (TipiAeroplanit)cboTipiAeroplanit.SelectedItem;
                
                MarkaAeroplanitDB madb = new MarkaAeroplanitDB(ma);
                madb.Shkruaj();

                cboMarkaAeroplanit.Items.Add(ma);
                cboMarkaAeroplanit.SelectedItem = ma;
            }
        }
    }
}
