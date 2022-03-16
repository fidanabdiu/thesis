using System;
using System.Windows.Forms;
using AgjensioniTuristik.Veglat;

namespace AgjensioniTuristik.FormatBaze
{
    public partial class MesazhiBaze : Form
    {
        public MesazhiBaze(LlojiMesazhit llm, string mesazhi, Butonat b)
        {
            InitializeComponent();
            TregojeMesazhin(llm, mesazhi, b);
        }

        private void TregojeMesazhin(LlojiMesazhit llm, string mesazhi, Butonat b)
        {
            switch (llm)
            {
                case LlojiMesazhit.Gabim:
                    Text = "Gabim";
                    pictureBox1.Image = imageList1.Images[2];
                    break;
                case LlojiMesazhit.Informacion:
                    Text = "Informacion";
                    pictureBox1.Image = imageList1.Images[1];
                    break;
                case LlojiMesazhit.Verejtje:
                    Text = "Vërejtje";
                    pictureBox1.Image = imageList1.Images[0];
                    break;
            }

            lblMesazhi.Text = mesazhi;

            switch (b)
            {
                case Butonat.Dil:
                    btnDil.Visible = true;
                    btnOK.Visible = false;
                    break;
                case Butonat.OKDil:
                    btnDil.Visible = true;
                    btnOK.Visible = true;
                    break;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
