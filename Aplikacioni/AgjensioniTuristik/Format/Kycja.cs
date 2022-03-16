using System;
using System.Windows.Forms;
using AgjensioniTuristik.Serveri;

namespace AgjensioniTuristik.Format
{
    public partial class Kycja : FormatBaze.DialoguBaze
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
                WSSoapClient sc = new WSSoapClient();

                PerdoruesiAgjensionit pa = sc.Kycu(txtPseudonimi.Text, txtFjalekalimi.Text);

                if (pa != null)
                {
                    Veglat.Veglat.PerdoruesiIKycur = pa;
                    DialogResult = DialogResult.OK;
                    return;
                }

                Mesazhi("Gabim pseudonimi apo fjalëkalimi");
            }
        }
    }
}
