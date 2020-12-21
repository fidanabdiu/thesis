using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BiznesLogjika;

namespace Aeroporti.Listat
{
    public class AeroplaniListe : ListViewItem
    {
        private Aeroplani aAeroplani;

        public AeroplaniListe(Aeroplani a)
        {
            aAeroplani = a;

            VendoseAeroplanin();
        }

        public void VendoseAeroplanin()
        {
            SubItems.Clear();

            Text = aAeroplani.ID.ToString();
            SubItems.Add(aAeroplani.LinjaAjrore.ToString());
            SubItems.Add(aAeroplani.TipiAeroplanit.ToString());
            SubItems.Add(aAeroplani.MarkaAeroplanit.ToString());
            SubItems.Add(aAeroplani.NumriUleseve.ToString());
        }

        public Aeroplani AeroplaniIZgjedhur
        {
            get { return aAeroplani; }
        }
    }
}
