using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AgjensioniTuristik.Serveri;

namespace AgjensioniTuristik.Listat
{
    public class PerdoruesiListe : ListViewItem
    {
        private PerdoruesiAgjensionit aPerdoruesi;

        public PerdoruesiListe(PerdoruesiAgjensionit p)
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

        public PerdoruesiAgjensionit PerdoruesiIZgjedhur
        {
            get { return aPerdoruesi; }
        }
    }
}
