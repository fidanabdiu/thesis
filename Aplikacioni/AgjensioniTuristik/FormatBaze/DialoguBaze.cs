using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AgjensioniTuristik.FormatBaze
{
    public partial class DialoguBaze : Form
    {
        public DialoguBaze()
        {
            InitializeComponent();
        }

        protected void Mesazhi(string mesazhi)
        {
            MesazhiBaze forma = new MesazhiBaze(AgjensioniTuristik.Veglat.LlojiMesazhit.Verejtje, mesazhi, AgjensioniTuristik.Veglat.Butonat.Dil);
            forma.ShowDialog();
        }
    }
}
