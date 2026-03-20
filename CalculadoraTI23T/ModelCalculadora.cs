using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTI23T
{
    class ModelCalculadora
    {
        //1° Variavel = Globalmente = Código inteiro exerga ela
        private double num1;//Encapsular a variavel
        private double num2;
        private double resultado;

        //Método que instancia as variaveis = da valores iniciais
        //2° Método construtor
        public ModelCalculadora()
        {
            this.num1 = 0;
            this.num2 = 0;
            this.resultado = 0;
        }//fim do construtor

        public ModelCalculadora(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        //Metodo GET e SET

        public double getNum1()
        {
            return this.num1;
        } //fim do get

        public double getNum2()
        {
            return this.num2;
        }//fim do get

        public double getResultado()
        {
            return this.resultado;
        }

        public void setNum1(double num1)
        {
            this.num1 = num1;
        }

        public void setNum2(double num2)
        {
            this.num2 = num2;
        }

        public void setResultado(double resultado)
        {
            this.resultado = resultado;
        }

        public double somar()
        {
            this.setResultado(this.getNum1() + this.getNum2());
            return this.getResultado();
        }

        public double subtrair()
        {
            this.setResultado(this.getNum1() - this.getNum2());
            return this.getResultado();
        }

        public double multiplicar()
        {
            this.setResultado(this.getNum1() * this.getNum2());
            return this.getResultado();
        }

        public double dividir()
        {
            if (this.getNum2() == 0) 
            {
                return -1; //indica que nao da pra dividir por 0
            }
            else 
            {
                this.setResultado(this.getNum1() / this.getNum2());
                return this.getResultado();
            }
                
        }

        //potencia
        public double potencia() 
        {
            this.setResultado(Math.Pow(this.getNum1(), this.getNum2()));
            return this.getResultado();
        }

        public double raizPrimeiroNumero() 
        {
            this.setResultado(Math.Sqrt(this.getNum1()));
            return this.getResultado();
        }

        public double raizSegundoNumero() 
        {
            this.setResultado(Math.Sqrt(this.getNum2()));
            return this.getResultado();
        }

    }//fim da classe model
}//fim do projetoCalculadoraTI23T
