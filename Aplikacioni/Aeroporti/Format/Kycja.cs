using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BiznesLogjika;
using ShtresaETeDhenave;

namespace Aeroporti.Format
{
    public partial class Kycja : Aeroporti.FormatBaze.DialoguBaze
    {
        public Kycja()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtPseudonimi.Text.Length == 0 || txtFjalekalimi.Text.Length == 0)
            {
                Mesazhi("Të gjitha fushat duhet të plotësohen");
            }
            else
            {
                List<PerdoruesiAeroportit> lp = new List<PerdoruesiAeroportit>();

                PerdoruesitAeroportitDB pdb = new PerdoruesitAeroportitDB(lp);
                pdb.Lexo("");

                foreach (PerdoruesiAeroportit p in lp)
                {
                    if (p.Pseudonimi == txtPseudonimi.Text && p.Fjalekalimi == txtFjalekalimi.Text)
                    {
                        Veglat.Veglat.PerdoruesiIKycur = p;
                        DialogResult = DialogResult.OK;
                        return;
                    }
                }

                Mesazhi("Gabim pseudonimi apo fjalëkalimi");
            }
        }
    }
}
