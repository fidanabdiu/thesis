using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BiznesLogjika;

namespace Aeroporti.Listat
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
            SubItems.Add(aRezervimi.PerdoruesiAgjensionit.Agjensioni.ToString());
            SubItems.Add(aRezervimi.Fluturimi.ToString());
            SubItems.Add(aRezervimi.Udhetari.ToString());
            SubItems.Add(aRezervimi.Ulesja.ToString());
            SubItems.Add(aRezervimi.LlojiRezervimit.ToString());
            SubItems.Add(aRezervimi.Cmimi.ToString("C"));
        }

        public Rezervimi RezervimiIZgjedhur
        {
            get { return aRezervimi; }
        }
    }
}
