using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BiznesLogjika;

namespace Aeroporti.Listat
{
    public class PerdoruesiListe : ListViewItem
    {
        private PerdoruesiAeroportit aPerdoruesi;

        public PerdoruesiListe(PerdoruesiAeroportit p)
        {
            aPerdoruesi = p;

            VendosePerdoruesin();
        }

        public void VendosePerdoruesin()
        {
            SubItems.Clear();

            Text = aPerdoruesi.Emri + " " + aPerdoruesi.Mbiemri;
            SubItems.Add(aPerdoruesi.NumriIdentifikues);
            SubItems.Add(aPerdoruesi.DokumentiIdentifikues.ToString());
            SubItems.Add(aPerdoruesi.Datelindja.ToShortDateString());
            SubItems.Add(aPerdoruesi.Vendlindja);
            SubItems.Add(aPerdoruesi.Vendbanimi);
            SubItems.Add(aPerdoruesi.Adresa);
            SubItems.Add(aPerdoruesi.TelefoniFiks);
            SubItems.Add(aPerdoruesi.TelefoniMobil);
            SubItems.Add(aPerdoruesi.Emaili);
            SubItems.Add(aPerdoruesi.Pseudonimi);
            SubItems.Add(aPerdoruesi.Privilegji.ToString());
        }

        public PerdoruesiAeroportit PerdoruesiIZgjedhur
        {
            get { return aPerdoruesi; }
        }
    }
}
