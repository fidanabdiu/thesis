using System.Windows.Forms;

namespace AgjensioniTuristik.FormatBaze
{
    public partial class EntitetetBaze : Form
    {
        public EntitetetBaze()
        {
            InitializeComponent();
        }

        protected void Mesazhi(string mesazhi)
        {
            lblMesazhi.Text = mesazhi;
        }
    }
}
