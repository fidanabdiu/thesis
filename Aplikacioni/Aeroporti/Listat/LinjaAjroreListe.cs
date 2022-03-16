using System.Windows.Forms;
using BiznesLogjika;

namespace Aeroporti.Listat
{
    public class LinjaAjroreListe : ListViewItem
    {
        private LinjaAjrore aLinjaAjrore;

        public LinjaAjroreListe(LinjaAjrore la)
        {
            aLinjaAjrore = la;

            VendoseLinjenAjrore();
        }

        public void VendoseLinjenAjrore()
        {
            SubItems.Clear();

            Text = aLinjaAjrore.Emri;
        }

        public LinjaAjrore LinjaEZgjedhur
        {
            get { return aLinjaAjrore; }
        }
    }
}
