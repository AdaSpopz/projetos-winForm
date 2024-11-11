using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace aula1610
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static class Globals
        {
            public static string numero_voto = "";
            public static int briggs_voto = 0;
            public static int clecio_voto = 0;
            public static int wendel_voto = 0;
            public static int total_voto = 0;
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            Globals.numero_voto = Globals.numero_voto + "1";
            lbl_visor.Text = Globals.numero_voto;

            if (Globals.numero_voto == "77")
            {
                pic_candidato.Image = Properties.Resources.wendel;
                lbl_candidato.Text = "Wendel Bezerra";
            }
            else if (Globals.numero_voto == "23")
            {
                pic_candidato.Image = Properties.Resources.briggs;
                lbl_candidato.Text = "Guilherme Briggs";
            }
            else if (Globals.numero_voto == "58")
            {
                pic_candidato.Image = Properties.Resources.clecio;
                lbl_candidato.Text = "Clécio Souto";
            }
            else
            {
                pic_candidato.Image = null;
                lbl_candidato.Text = "Voto nulo";
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            Globals.numero_voto = Globals.numero_voto + "2";
            lbl_visor.Text = Globals.numero_voto;

            if (Globals.numero_voto == "77")
            {
                pic_candidato.Image = Properties.Resources.wendel;
                lbl_candidato.Text = "Wendel Bezerra";
            }
            else if (Globals.numero_voto == "23")
            {
                pic_candidato.Image = Properties.Resources.briggs;
                lbl_candidato.Text = "Guilherme Briggs";
            }
            else if (Globals.numero_voto == "58")
            {
                pic_candidato.Image = Properties.Resources.clecio;
                lbl_candidato.Text = "Clécio Souto";
            }
            else
            {
                pic_candidato.Image = null;
                lbl_candidato.Text = "Voto nulo";
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            Globals.numero_voto = Globals.numero_voto + "3";
            lbl_visor.Text = Globals.numero_voto;

            if (Globals.numero_voto == "77")
            {
                pic_candidato.Image = Properties.Resources.wendel;
                lbl_candidato.Text = "Wendel Bezerra";
            }
            else if (Globals.numero_voto == "23")
            {
                pic_candidato.Image = Properties.Resources.briggs;
                lbl_candidato.Text = "Guilherme Briggs";
            }
            else if (Globals.numero_voto == "58")
            {
                pic_candidato.Image = Properties.Resources.clecio;
                lbl_candidato.Text = "Clécio Souto";
            }
            else
            {
                pic_candidato.Image = null;
                lbl_candidato.Text = "Voto nulo";
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            Globals.numero_voto = Globals.numero_voto + "4";
            lbl_visor.Text = Globals.numero_voto;

            if (Globals.numero_voto == "77")
            {
                pic_candidato.Image = Properties.Resources.wendel;
                lbl_candidato.Text = "Wendel Bezerra";
            }
            else if (Globals.numero_voto == "23")
            {
                pic_candidato.Image = Properties.Resources.briggs;
                lbl_candidato.Text = "Guilherme Briggs";
            }
            else if (Globals.numero_voto == "58")
            {
                pic_candidato.Image = Properties.Resources.clecio;
                lbl_candidato.Text = "Clécio Souto";
            }
            else
            {
                pic_candidato.Image = null;
                lbl_candidato.Text = "Voto nulo";
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            Globals.numero_voto = Globals.numero_voto + "5";
            lbl_visor.Text = Globals.numero_voto;

            if (Globals.numero_voto == "77")
            {
                pic_candidato.Image = Properties.Resources.wendel;
                lbl_candidato.Text = "Wendel Bezerra";
            }
            else if (Globals.numero_voto == "23")
            {
                pic_candidato.Image = Properties.Resources.briggs;
                lbl_candidato.Text = "Guilherme Briggs";
            }
            else if (Globals.numero_voto == "58")
            {
                pic_candidato.Image = Properties.Resources.clecio;
                lbl_candidato.Text = "Clécio Souto";
            }
            else
            {
                pic_candidato.Image = null;
                lbl_candidato.Text = "Voto nulo";
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            Globals.numero_voto = Globals.numero_voto + "6";
            lbl_visor.Text = Globals.numero_voto;

            if (Globals.numero_voto == "77")
            {
                pic_candidato.Image = Properties.Resources.wendel;
                lbl_candidato.Text = "Wendel Bezerra";
            }
            else if (Globals.numero_voto == "23")
            {
                pic_candidato.Image = Properties.Resources.briggs;
                lbl_candidato.Text = "Guilherme Briggs";
            }
            else if (Globals.numero_voto == "58")
            {
                pic_candidato.Image = Properties.Resources.clecio;
                lbl_candidato.Text = "Clécio Souto";
            }
            else
            {
                pic_candidato.Image = null;
                lbl_candidato.Text = "Voto nulo";
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            Globals.numero_voto = Globals.numero_voto + "7";
            lbl_visor.Text = Globals.numero_voto;

            if (Globals.numero_voto == "77")
            {
                pic_candidato.Image = Properties.Resources.wendel;
                lbl_candidato.Text = "Wendel Bezerra";
            }
            else if (Globals.numero_voto == "23")
            {
                pic_candidato.Image = Properties.Resources.briggs;
                lbl_candidato.Text = "Guilherme Briggs";
            }
            else if (Globals.numero_voto == "58")
            {
                pic_candidato.Image = Properties.Resources.clecio;
                lbl_candidato.Text = "Clécio Souto";
            }
            else
            {
                pic_candidato.Image = null;
                lbl_candidato.Text = "Voto nulo";
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            Globals.numero_voto = Globals.numero_voto + "8";
            lbl_visor.Text = Globals.numero_voto;

            if (Globals.numero_voto == "77")
            {
                pic_candidato.Image = Properties.Resources.wendel;
                lbl_candidato.Text = "Wendel Bezerra";
            }
            else if (Globals.numero_voto == "23")
            {
                pic_candidato.Image = Properties.Resources.briggs;
                lbl_candidato.Text = "Guilherme Briggs";
            }
            else if (Globals.numero_voto == "58")
            {
                pic_candidato.Image = Properties.Resources.clecio;
                lbl_candidato.Text = "Clécio Souto";
            }
            else
            {
                pic_candidato.Image = null;
                lbl_candidato.Text = "Voto nulo";
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            Globals.numero_voto = Globals.numero_voto + "9";
            lbl_visor.Text = Globals.numero_voto;

            if (Globals.numero_voto == "77")
            {
                pic_candidato.Image = Properties.Resources.wendel;
                lbl_candidato.Text = "Wendel Bezerra";
            }
            else if (Globals.numero_voto == "23")
            {
                pic_candidato.Image = Properties.Resources.briggs;
                lbl_candidato.Text = "Guilherme Briggs";
            }
            else if (Globals.numero_voto == "58")
            {
                pic_candidato.Image = Properties.Resources.clecio;
                lbl_candidato.Text = "Clécio Souto";
            }
            else
            {
                pic_candidato.Image = null;
                lbl_candidato.Text = "Voto nulo";
            }
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            Globals.numero_voto = Globals.numero_voto + "0";
            lbl_visor.Text = Globals.numero_voto;

            if (Globals.numero_voto == "77")
            {
                pic_candidato.Image = Properties.Resources.wendel;
                lbl_candidato.Text = "Wendel Bezerra";
            }
            else if (Globals.numero_voto == "23")
            {
                pic_candidato.Image = Properties.Resources.briggs;
                lbl_candidato.Text = "Guilherme Briggs";
            }
            else if (Globals.numero_voto == "58")
            {
                pic_candidato.Image = Properties.Resources.clecio;
                lbl_candidato.Text = "Clécio Souto";
            }
            else
            {
                pic_candidato.Image = null;
                lbl_candidato.Text = "Voto nulo";
            }
        }

        private void btn_branco_Click(object sender, EventArgs e)
        {
            Globals.numero_voto = "";
            lbl_visor.Text = "0";

            if (Globals.numero_voto == "77")
            {
                pic_candidato.Image = Properties.Resources.wendel;
                lbl_candidato.Text = "Wendel Bezerra";
            }
            else if (Globals.numero_voto == "23")
            {
                pic_candidato.Image = Properties.Resources.briggs;
                lbl_candidato.Text = "Guilherme Briggs";
            }
            else if (Globals.numero_voto == "58")
            {
                pic_candidato.Image = Properties.Resources.clecio;
                lbl_candidato.Text = "Clécio Souto";
            }
            else
            {
                pic_candidato.Image = null;
                lbl_candidato.Text = "";
            }
        }

        private void btn_corrige_Click(object sender, EventArgs e)
        {
            if (Globals.numero_voto.Length > 0)
            {
                Globals.numero_voto = Globals.numero_voto.Remove(Globals.numero_voto.Length - 1);
                if (Globals.numero_voto.Length > 0)
                {
                    lbl_visor.Text = Globals.numero_voto;
                }
                else
                {
                    lbl_visor.Text = "0";
                }

            }
            else
            {
                lbl_visor.Text = "0";
            }

            if (Globals.numero_voto == "77")
            {
                pic_candidato.Image = Properties.Resources.wendel;
                lbl_candidato.Text = "Wendel Bezerra";
            }
            else if (Globals.numero_voto == "23")
            {
                pic_candidato.Image = Properties.Resources.briggs;
                lbl_candidato.Text = "Guilherme Briggs";
            }
            else if (Globals.numero_voto == "58")
            {
                pic_candidato.Image = Properties.Resources.clecio;
                lbl_candidato.Text = "Clécio Souto";
            }
            else
            {
                pic_candidato.Image = null;
                lbl_candidato.Text = "Voto nulo";
            }
        }

        private async void btn_confirma_Click(object sender, EventArgs e)
        {

            if (lbl_candidato.Text == "")
            {
                lbl_candidato.Text = "Voto nulo";
            }

            lbl_visor.Font = new Font("Arial", 25);
            lbl_visor.Text = "Voto confirmado.";

            btn_0.Enabled = false;
            btn_1.Enabled = false;
            btn_2.Enabled = false;
            btn_3.Enabled = false;
            btn_4.Enabled = false;
            btn_5.Enabled = false;
            btn_6.Enabled = false;
            btn_7.Enabled = false;
            btn_8.Enabled = false;
            btn_9.Enabled = false;
            btn_branco.Enabled = false;
            btn_corrige.Enabled = false;
            btn_confirma.Enabled = false;
            btn_candidato.Enabled = false;

            await Task.Delay(2000);
            lbl_visor.Text = "FIM.";
            lbl_visor.Font = new Font("Arial", 40);
            await Task.Delay(2000);

            btn_0.Enabled = true;
            btn_1.Enabled = true;
            btn_2.Enabled = true;
            btn_3.Enabled = true;
            btn_4.Enabled = true;
            btn_5.Enabled = true;
            btn_6.Enabled = true;
            btn_7.Enabled = true;
            btn_8.Enabled = true;
            btn_9.Enabled = true;
            btn_branco.Enabled = true;
            btn_corrige.Enabled = true;
            btn_confirma.Enabled = true;
            btn_candidato.Enabled = true;


            if (Globals.numero_voto == "77")
            {
                Globals.wendel_voto += 1;

            }
            else if (Globals.numero_voto == "23")
            {
                Globals.briggs_voto += 1;

            }
            else if (Globals.numero_voto == "58")
            {
                Globals.clecio_voto += 1;

            }
            lbl_visor.Text = "0";
            Globals.numero_voto = "";
            pic_candidato.Image = null;
            lbl_candidato.Text = "";
            Globals.total_voto += 1;



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void box_visor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_candidato_Click(object sender, EventArgs e)
        {
            especificacoes form2 = new especificacoes(Globals.briggs_voto, Globals.wendel_voto, Globals.clecio_voto, Globals.total_voto);
            form2.Show();
        }
    }
}
