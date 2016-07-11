using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BiznesLogjika;

namespace Aeroporti.Listat
{
    public class QytetiListe : ListViewItem
    {
        private Qyteti aQyteti;

        public QytetiListe(Qyteti q)
        {
            aQyteti = q;
            VendoseQytetin();
        }

        public void VendoseQytetin()
        {
            SubItems.Clear();

            Text = aQyteti.Emri;
            SubItems.Add(aQyteti.Shteti.Emri);
        }

        public Qyteti QytetiIZgjedhur
        {
            get { return aQyteti; }
        }
    }
}
