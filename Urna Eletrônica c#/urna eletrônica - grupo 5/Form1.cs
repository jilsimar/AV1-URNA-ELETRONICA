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
    public partial class Form1 : Form
    {

        string numero; //armazena o número do candidato

        int candidato17, candidato13, candidato45, branco, nulo;
        int a = 0;
        public Form1()
        {
            InitializeComponent();
        }



        private void btnNumero(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtNum.Text = txtNum.Text + bt.Text;

        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtDireita_TextChanged_1(object sender, EventArgs e)
        {
            numero = txtNum.Text;

            if (numero == "17")
            {
                pictureBox1.Image = Properties.Resources.bolsonaro;
                lblNomeCandidato.Text = "Bolsonaro";

            }

            else if (numero == "13")
            {
                pictureBox1.Image = Properties.Resources.haddad;
                lblNomeCandidato.Text = "Haddad";
            }

            else if (numero == "45")
            {
                pictureBox1.Image = Properties.Resources.geraldo_Alckmin;
                lblNomeCandidato.Text = "Geraldo Alckmin";
            }
           
            else if (numero != "1" && numero != "2" && numero != "3" && numero != "4" && numero != "5" && numero != "6" &&
                  numero != "7" && numero != "8" && numero != "9" && numero != "0" && numero != "--")
            {
                pictureBox1.Image = Properties.Resources.fundobranco_urna;
            }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            var resultado = new Form2(candidato17, candidato13, candidato45, branco, nulo);
            resultado.ShowDialog();
        }
        private void button13_Click_1(object sender, EventArgs e)
        {
            {
                if (numero == "17")
                {
                    candidato17 += 1;
                    lblNomeCandidato.ResetText();
                    pictureBox1.Image = Properties.Resources.bolsonaro;
                    txtNum.Clear();
                }
                else if (numero == "13")
                {
                    candidato13 += 1;
                    lblNomeCandidato.ResetText();
                    pictureBox1.Image = Properties.Resources.haddad;
                    txtNum.Clear();
                }
                else if (numero == "45")
                {
                    candidato45 += 1;
                    lblNomeCandidato.ResetText();
                    pictureBox1.Image = Properties.Resources.geraldo_Alckmin;
                    txtNum.Clear();
                }
                else if (numero == "--")
                {
                    branco += 1;
                    txtNum.Clear();
                }

                else
                {
                    nulo += 1;
                    txtNum.Clear();
                }
            }
        }
        private void button14_Click_1(object sender, EventArgs e)
        {
            txtNum.Text = "";
            lblNomeCandidato.Text = "";
            a = 0;
        }

        

        private void button15_Click_1(object sender, EventArgs e)
        {
           
            txtNum.Text = "--";
        }

       

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }




    }
}






