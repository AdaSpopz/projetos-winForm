using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula1610
{
    public partial class especificacoes : Form
    {

        public static int briggs, clecio, wendel, totalVoto;
        public especificacoes(int briggs_voto, int wendel_voto, int clecio_voto, int total_voto)
        {
            briggs = briggs_voto;
            clecio = clecio_voto; 
            wendel = wendel_voto;
            totalVoto = total_voto;
            InitializeComponent();
        }

        private void btn_apurar_Click(object sender, EventArgs e)
        {
           

            lbl_Total.Text = "Total votos: " + totalVoto.ToString();

            lbl_votoBriggs.Text = "Votos: " + briggs.ToString();
            lbl_votoWendel.Text = "Votos: " + wendel.ToString();
            lbl_votoClecio.Text = "Votos: " + clecio.ToString();

        }
    }
}
