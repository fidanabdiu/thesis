using System;
using System.Windows.Forms;
using AgjensioniTuristik.Format;
using AgjensioniTuristik.Serveri;
using AgjensioniTuristik.FormatBaze;
using AgjensioniTuristik.Veglat;

namespace AgjensioniTuristik
{
    public partial class FormaKryesore : Form
    {
        public FormaKryesore()
        {
            InitializeComponent();

            label1.Text += " " + Veglat.Veglat.PerdoruesiIKycur.Agjensioni.Emri;
            label2.Text += " " + Veglat.Veglat.PerdoruesiIKycur.Emri + " " + Veglat.Veglat.PerdoruesiIKycur.Mbiemri;

            KontrolloPrivilegjin();
        }

        private void KontrolloPrivilegjin()
        {
            switch (Veglat.Veglat.PerdoruesiIKycur.Privilegji)
            {
                case Privilegji.Administrator:
                    button3.Enabled = true;
                    break;
                case Privilegji.Punetor:
                    button3.Enabled = false;
                    break;
            }
        }

        private void TregojeFormen(Form f)
        {
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Format.Programi forma = new AgjensioniTuristik.Format.Programi();
            forma.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fjalekalimi forma = new Fjalekalimi(Veglat.Veglat.PerdoruesiIKycur);

            if (forma.ShowDialog() == DialogResult.OK)
            {
                WSSoapClient sc = new WSSoapClient();
                sc.PerdoruesiAgjensionitNdrysho(Veglat.Veglat.PerdoruesiIKycur);

                MesazhiBaze mesazhi = new MesazhiBaze(LlojiMesazhit.Informacion, "Fjalëkalimi juaj u ndërrua me sukses", Butonat.Dil);
                mesazhi.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Perdoruesit forma = Perdoruesit.MerreInstancen();
            TregojeFormen(forma);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Fluturimet forma = Fluturimet.MerreInstancen();
            TregojeFormen(forma);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Rezervimet forma = Rezervimet.MerreInstancen();
            TregojeFormen(forma);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Udhetaret forma = Udhetaret.MerreInstancen();
            TregojeFormen(forma);
        }
    }
}
