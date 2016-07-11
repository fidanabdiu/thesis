using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AgjensioniTuristik.Format
{
    public partial class Kerko : FormatBaze.DialoguBaze
    {
        public Kerko()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtFjalaKyce.Text.Length == 0)
            {
                Mesazhi("Jipeni fjalën kyçe");
                txtFjalaKyce.Focus();
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }

        public string FjalaKyce
        {
            get { return txtFjalaKyce.Text; }
        }
    }
}
