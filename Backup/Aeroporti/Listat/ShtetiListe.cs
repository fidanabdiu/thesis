using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BiznesLogjika;

namespace Aeroporti.Listat
{
    public class ShtetiListe : ListViewItem
    {
        private Shteti aShteti;

        public ShtetiListe(Shteti sh)
        {
            aShteti = sh;
            VendoseShtetin();
        }

        public void VendoseShtetin()
        {
            SubItems.Clear();

            Text = aShteti.Emri;
        }

        public Shteti ShtetiIZgjedhur
        {
            get { return aShteti; }
        }
    }
}
