using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPenha
{
    class ModelCalculadora
    {
        private double operacao;
        public ModelCalculadora() 
        {
            ConsultarOperacao = 0;
        }//Fim do Método construtor

        public double ConsultarOperacao
        {
            get { return operacao; }
            set { this.operacao = value; }
        }//Fim do Método

        public double Somar(double num)
        {
            return ConsultarOperacao += num;
        }//Fim do Somar

        public double Subtracao(double num)
        {
            return ConsultarOperacao -= num;
        }//Fim do Subtração

        public double Divisao(double num)
        {
            return ConsultarOperacao /= num;
        }//Fim do Divisão

        public double Multiplicacao(double num)
        {
            return ConsultarOperacao *= num;
        }//Fim do Multiplicação

        public double Raiz(double num)
        {
            return ConsultarOperacao /= num / num;
        }//Fim do Raiz

        public double Potencia(double num)
        {
            return ConsultarOperacao *= num * num;
        }//Fim do Potência
    }
}
