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
    public partial class randomnumber : Form
    {
        public randomnumber()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            megasena megasena = new megasena();
            megasena.Show();
        }

        private void button_lotomania_Click(object sender, EventArgs e)
        {
            lotomania lotomania = new lotomania();
            lotomania.Show();
        }

        private void button_quina_Click(object sender, EventArgs e)
        {
            quina quina = new quina();
            quina.Show();
        }

        private void button_duplasena_Click(object sender, EventArgs e)
        {
            duplasena duplasena = new duplasena();
            duplasena.Show();
        }
    }
}
