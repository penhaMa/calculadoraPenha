using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraPenha
{
    public partial class Form1 : Form
    {
        ModelCalculadora modelo;
        public Form1()
        {
            InitializeComponent();
            this.modelo = new ModelCalculadora();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "" + this.modelo.Subtracao(Convert.ToDouble(maskedTextBox1.Text));
        }// Subtração

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "" + this.modelo.Somar(Convert.ToDouble(maskedTextBox1.Text));

        }// Soma

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = "" + this.modelo.Raiz(Convert.ToDouble(maskedTextBox1.Text));
        }// Raiz

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "" + this.modelo.Divisao(Convert.ToDouble(maskedTextBox1.Text));
        }// Divisão

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = "" + this.modelo.Multiplicacao(Convert.ToDouble(maskedTextBox1.Text));
        }// Multiplicação

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text = "" + this.modelo.Potencia(Convert.ToDouble(maskedTextBox1.Text));
        }// Potência

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }// Resultado

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text = "O Resultado é .....";
        }// Limpar

    }//Fim da Classe
}//Fim do Projeto
