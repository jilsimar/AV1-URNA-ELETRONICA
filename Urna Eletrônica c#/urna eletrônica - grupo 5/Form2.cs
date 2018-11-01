using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace urna_eletrônica___grupo_5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(int candidato17, int candidato13, int candidato45, int nulo, int branco)
        {
            InitializeComponent();
            label1.Text = Convert.ToString(candidato17);
            label2.Text = Convert.ToString(candidato13);
            label3.Text = Convert.ToString(candidato45);
            label5.Text = Convert.ToString(nulo);
            label4.Text = Convert.ToString(branco);
        }

       

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}