using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
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
        }//FIm do metodo

        //Raiz do primeiro numero
        public double raizPrimeiroNumero()
        {
            this.setResultado(Math.Sqrt(this.getNum1()));
            return this.getResultado();
        }//fim do metodo

        //Raiz do segundo numero
        public double raizSegundoNumero()
        {
            this.setResultado(Math.Sqrt(this.getNum2()));
            return this.getResultado();
        }//Fim do metodo

        public string tabuada(int num)
        {
            string msg = "";
            for (int i = 0; i <= 10; i++)
            { 
                msg += "\n" + num + " * " + i + " = " + (num* i);
            }//Fim do for
            return msg;
        }//Fim do metodo

        public string bissexto(int ano)
        {

            if ((ano % 4 == 0) || (ano % 4 == 0 && ano % 100 != 0))
            {
                return $"{ano} é bissexto";//Interpolação
            }
            else
            {
                return $"{ano} NÃO é bissexto";
            }
        }//fim do bissexto

        public string verificarNum(int verificar) 
        {
            if (verificar < 100 || verificar > 200) 
            {
                return $"{verificar} nao esta entre 100 e 200";
            }
            else 
            {
                return $"{verificar} esta entre 100 e 200";
            }
        }

        public string verificarIdade(int idade) 
        {
            if(idade < 16) 
            {
                return $"com a idade:{idade} voce nao pode votar";
            }
            else 
            {
                return $"com essa idade:{idade} voce pode votar";
            }
        }

        public string verificarIntervalo(int intervalo , int intervaloComeco, int intervaloFinal) 
        {
            if (intervalo < intervaloComeco || intervalo > intervaloFinal) 
            {
                return $"O número:{intervalo} nao esta no intervalo";
            }
            else
            {
                return $"O numero:{intervalo} esta no intervalo";
            }
        }

        //exercicio 14:

        public string definirMaiorMenor() 
        {
            int num = 0;
            int maior = 0;
            int menor = 0;
            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine((i+1) + "° Número");
                num1 = Convert.ToInt32(Console.ReadLine());

                if(i == 0) 
                {
                    maior = num;
                    menor = num;
                }
                if (num > maior) 
                {
                    maior = num;
                }
                if (num < menor) 
                {
                    menor = num;
                }
            }
            return $" O maior é: {maior} e o menor é: {menor}";
        }

    }//fim da classe model
}//fim do projetoCalculadoraTI23T
