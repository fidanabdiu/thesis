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
