using System.Windows.Forms;
using AgjensioniTuristik.Serveri;
using System.Drawing;

namespace AgjensioniTuristik.Listat
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
            SubItems.Add(aFluturimi.Aeroplani.ID.ToString());
            SubItems.Add(aFluturimi.Qyteti.Emri);
            SubItems.Add(aFluturimi.DataNisjes.ToShortDateString());
            SubItems.Add(aFluturimi.OraNisjes.ToShortTimeString());
            SubItems.Add(aFluturimi.PerdoruesiAeroportit.Emri + " " + aFluturimi.PerdoruesiAeroportit.Mbiemri);
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
