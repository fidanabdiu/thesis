﻿using System;
using System.Windows.Forms;
using BiznesLogjika;

namespace Aeroporti.Format
{
    public partial class LinjeERe : FormatBaze.DialoguBaze
    {
        private LinjaAjrore aLinjaAjrore;
        
        public LinjeERe(LinjaAjrore la)
        {
            InitializeComponent();

            aLinjaAjrore = la;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtEmri.Text.Length == 0)
                Mesazhi("Shkruajeni emrin e linjës ajrore");
            else
            {
                aLinjaAjrore.Emri = txtEmri.Text;

                DialogResult = DialogResult.OK;
            }
        }
    }
}
