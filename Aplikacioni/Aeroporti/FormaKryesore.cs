using System;
using System.Windows.Forms;
using BiznesLogjika;
using ShtresaETeDhenave;
using Aeroporti.FormatBaze;
using Aeroporti.Format;

namespace Aeroporti
{
    public partial class FormaKryesore : Form
    {
        public FormaKryesore()
        {
            InitializeComponent();

            label1.Text += " " + Veglat.Veglat.PerdoruesiIKycur.Emri + " " + Veglat.Veglat.PerdoruesiIKycur.Mbiemri;

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
            Format.Programi forma = new Aeroporti.Format.Programi();
            forma.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fjalekalimi forma = new Fjalekalimi(Veglat.Veglat.PerdoruesiIKycur);

            if (forma.ShowDialog() == DialogResult.OK)
            {
                PerdoruesiAeroportitDB padb = new PerdoruesiAeroportitDB(Veglat.Veglat.PerdoruesiIKycur);
                padb.Ndrysho();

                MesazhiBaze mesazhi = new MesazhiBaze(Veglat.LlojiMesazhit.Informacion, "Fjalëkalimi juaj u ndërrua me sukses", Veglat.Butonat.Dil);
                mesazhi.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Perdoruesit forma = Perdoruesit.MerreInstancen();
            TregojeFormen(forma);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Shtetet forma = Shtetet.MerreInstancen();
            TregojeFormen(forma);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LinjatAjrore forma = LinjatAjrore.MerreInstancen();
            TregojeFormen(forma);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Fluturimet forma = Fluturimet.MerreInstancen();
            TregojeFormen(forma);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Agjensionet forma = Agjensionet.MerreInstancen();
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
