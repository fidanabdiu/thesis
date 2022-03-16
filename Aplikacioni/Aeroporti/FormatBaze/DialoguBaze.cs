using System.Windows.Forms;

namespace Aeroporti.FormatBaze
{
    public partial class DialoguBaze : Form
    {
        public DialoguBaze()
        {
            InitializeComponent();
        }

        protected void Mesazhi(string mesazhi)
        {
            MesazhiBaze forma = new MesazhiBaze(Veglat.LlojiMesazhit.Verejtje, mesazhi, Veglat.Butonat.Dil);
            forma.ShowDialog();
        }
    }
}
