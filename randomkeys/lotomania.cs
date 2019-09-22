using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace randomkeys
{
    

    public partial class lotomania : Form
    {

        List<int> usados = new List<int>();
       

        public lotomania()
        {
            InitializeComponent();
        }

        private void button_lotomania_gerar_Click(object sender, EventArgs e)
        {

            Resultado.Items.Clear();
            {

            }
            Random random = new Random();
            for (int i = 1; i < 51; i++)
            {
                int numero = random.Next(1, 101);
                if (usados.IndexOf(numero) == -1)
                    usados.Add(numero);
                Resultado.Items.Add(numero);    
            }
            MessageBox.Show(this, "Os números foram sorteados.", "Lotomania", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            MessageBox.Show(this, "Você deseja salvar este jogo?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void valordezenas_TextChanged(object sender, EventArgs e)
        {
            string ValorDezenas = valordezenas.Text;
        }

        private void lotomania_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
