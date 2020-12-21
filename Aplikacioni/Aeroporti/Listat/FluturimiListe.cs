using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BiznesLogjika;
using System.Drawing;

namespace Aeroporti.Listat
{
    public class FluturimiListe : ListViewItem
    {
        private Fluturimi aFluturimi;

        public FluturimiListe(Fluturimi f)
        {
            aFluturimi = f;

            VendoseFluturimin();
        }

        public void VendoseFluturimin()
        {
            SubItems.Clear();

            Text = aFluturimi.ID.ToString();
            SubItems.Add(aFluturimi.Aeroplani.ToString());
            SubItems.Add(aFluturimi.Qyteti.ToString());
            SubItems.Add(aFluturimi.DataNisjes.ToShortDateString());
            SubItems.Add(aFluturimi.OraNisjes.ToShortTimeString());
            SubItems.Add(aFluturimi.PerdoruesiAeroportit.ToString());
            SubItems.Add(aFluturimi.FluturimiAnuluar.ToString());
            SubItems.Add(aFluturimi.Cmimi.ToString("C"));
            SubItems.Add(aFluturimi.CmimiKthyes.ToString("C"));

            ForeColor = (aFluturimi.FluturimiAnuluar == FluturimiAnuluar.JO ? Color.Black : Color.Red);
        }

        public Fluturimi FluturimiIZgjedhur
        {
            get { return aFluturimi; }
        }
    }
}
