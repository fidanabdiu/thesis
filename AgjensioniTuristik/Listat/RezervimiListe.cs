using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AgjensioniTuristik.Serveri;

namespace AgjensioniTuristik.Listat
{
    public class RezervimiListe : ListViewItem
    {
        private Rezervimi aRezervimi;

        public RezervimiListe(Rezervimi r)
        {
            aRezervimi = r;
            VendoseRezervimin();
        }

        public void VendoseRezervimin()
        {
            SubItems.Clear();

            Text = aRezervimi.ID.ToString();
            SubItems.Add(aRezervimi.PerdoruesiAgjensionit.Emri + " " + aRezervimi.PerdoruesiAgjensionit.Mbiemri);
            SubItems.Add(aRezervimi.Fluturimi.ID.ToString());
            SubItems.Add(aRezervimi.Udhetari.Emri + " " + aRezervimi.Udhetari.Mbiemri);
            SubItems.Add(aRezervimi.Ulesja.Numri.ToString());
            SubItems.Add(aRezervimi.LlojiRezervimit.ToString());
            SubItems.Add(aRezervimi.Cmimi.ToString("C"));
        }

        public Rezervimi RezervimiIZgjedhur
        {
            get { return aRezervimi; }
        }
    }
}
