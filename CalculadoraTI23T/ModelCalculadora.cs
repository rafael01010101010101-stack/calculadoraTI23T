using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.Serialization;
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

        public string triangulo(double lado1, double lado2, double lado3) 
        {
            if (lado1 == lado2 && lado2 == lado3)
            {
                return $"O triângulo é equilatero";
            }
            if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3) 
            {
                return $"O triângulo é isosceles";
            }
            if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1) 
            {
                return $"O triângulo é escaleno";
            }
            return "Os valores nao forma um triangulo";
        }

        public string semana(int num1) 
        {
            if(num1 == 1)
            {
                return $"O dia da semana é segunda";
            }
            if(num1 == 2)
            {
                return $"O dia é terça";
            }
            if(num1 == 3) 
            {
                return $"O dia é quarta";
            }
            if(num1 == 4) 
            {
                return $"O dia é quinta";
            }
            if(num1 == 5) 
            {
                return $"O dia da semana é sexta";
            }
            if (num1 == 6) 
            {
                return $"O dia da semana é sabado";
            }
            if (num1 == 7) 
            {
                return $"O dia da semana é domingo";
            }
            return "Digite um número que esteja no intervalo de 1 a 7!";
        }

        public string senha(string senha1, string senha2) 
        {
            if (senha1 == senha2) 
            {
                return $"Essa é a senha válida!";
            }
            else 
            {
                return $"Essa não é a senha válida!";
            }
        }

        public string horarios(DateTime horario1, DateTime horario2) 
        {
            if(horario1 > horario2) 
            {
                return $"O primeiro horario é o maior";
            }
            else 
            {
                return $"O segundo horario é maior";
            }
        }

        public string numeros(double num11, double num22) 
        {
            if(num11 > num22) 
            {
                return $"O primeiro numero é maior";
            }
            else 
            {
                return $"O segundo numero é maior";
            }
        }

        public double media(double num01, double num02, double num03, double num04, double num05) 
        {
            return (num01 + num02 + num03 + num04 + num05) / 5;

        }

        public double numerosAteCem(double num011)
        {
            double soma = 0;

            for (int i = 0; soma <= 100; i++)
            {
                soma += num011;
            }
            return soma;
        }

        public void senhas(string senhaVerdade, string senhaFalsa)
        {
            do
            {
                Console.WriteLine("Informe a senha: ");
                senhaVerdade = Console.ReadLine();

                Console.WriteLine("Informe a senha novamente: ");
                senhaFalsa = Console.ReadLine();

                if(senhaFalsa != senhaVerdade) 
                {
                    Console.WriteLine("Essa não é a senha correta!");
                }
            }
            while (senhaVerdade != senhaFalsa);
              {
                Console.WriteLine("Essa é a senha Correta");
              }
            
        }

        public string definirMaiorMenor() 
        {
            int num = 0;
            int maior = 0;
            int menor = 0;
            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine((i+1) + "° Número");
                num = Convert.ToInt32(Console.ReadLine());

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

        public string idade(int idade1) 
        {
            if(idade1 < 13) 
            {
                return $"Com essa idade você é uma criança!";
            }
            if(idade1 > 13 && idade1 < 18) 
            {
                return $"Com essa idade você é um adolescente!";
            }
            if(idade1 > 18 && idade1 < 60) 
            {
                return $"Com essa idade você é um adulto!";
            }
            if(idade1 > 60) 
            {
                return $"Com essa idade você é um idoso";
            }
            return $"Digite um número valido!";
        }

    }//fim da classe model
}//fim do projetoCalculadoraTI23T
