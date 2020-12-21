using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            MesazhiBaze forma = new MesazhiBaze(Aeroporti.Veglat.LlojiMesazhit.Verejtje, mesazhi, Aeroporti.Veglat.Butonat.Dil);
            forma.ShowDialog();
        }
    }
}
