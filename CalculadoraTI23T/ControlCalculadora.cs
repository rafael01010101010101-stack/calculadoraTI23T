using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTI23T
{
    class ControlCalculadora
    {
        //Variaveis
        ModelCalculadora model; //começando a conectar a control e a model

        //Contrutor vazio da classe ModelCalculadora
        public ControlCalculadora() 
        {
            this.model = new ModelCalculadora(); //efetivando a ligação com o model    
        }//fim do construtor vazio

        public ControlCalculadora(double num1, double num2) 
        {
            this.model = new ModelCalculadora(num1, num2);
        }//fim do construtor com parametros

        //Metodo de menu
        public string mostrarMenu() 
        {
            return "--------Menu--------\n\n" +
                "Escolha uma das opções abaixo: \n" +
                "0. Sair\n" +
                "1. Somar\n" +
                "2. Subtrair\n" +
                "3. Multiplicar\n" +
                "4. Dividir\n" +
                "5. Potência\n" +
                "6. Raiz do Primeiro Numero\n" +
                "7. Raiz do Segundo Numero\n" +
                "8. Tabuada\n" +
                "9. Ano bissexto\n"+
                "10. Entre 100 e 200\n"+
                "11. Verificar se pode votar\n"+
                "12. Verificar se esta dentro de um intervalo\n"+
                "13. Leia um número e verifique se ele esta entre os 10 maiores lidos";

        }//fim do metodo

        public void realizarOperacao() 
        {
            int opcao = 0;//declarar do lado de fora do do...wrile()
            do
            {
                Console.WriteLine(this.mostrarMenu());//chamar menu
                opcao = Convert.ToInt32(Console.ReadLine());//leia
                if (opcao != 0 && opcao !=6 && opcao !=7 && opcao !=8 && opcao !=9 && opcao != 10 && opcao !=11 && opcao !=12 && opcao !=13) 
                {
                    this.coletar();//pegar oque o usuario esta digitando
                }
                switch (opcao)
                { 
                        case 0:
                                Console.WriteLine("Obrigado!");
                            break;
                        case 1:
                                Console.WriteLine("A soma é:" +this.model.somar());
                            break;
                        case 2:
                                Console.WriteLine("A substração é:" + this.model.subtrair());
                            break;
                        case 3:
                                Console.WriteLine("A mutiplicação é:" + this.model.multiplicar());
                            break;
                        case 4:
                                if (this.model.dividir() == -1)
                                {
                                    Console.WriteLine("Impossivel dividir por zero!!");
                                }
                                else
                                {
                                    Console.WriteLine("A divisão é:" + this.model.dividir());
                                }
                            break;
                        case 5:
                            
                            Console.WriteLine("A potência é: " + this.model.potencia());
                        break;
                        case 6:
                            Console.WriteLine("Informe um numero: ");
                            this.model.setNum1(Convert.ToInt32(Console.ReadLine()));
                            Console.WriteLine("A Raiz do Primeiro numero é: " + this.model.raizPrimeiroNumero());
                        break;
                        case 7:
                            Console.WriteLine("Informe um numero: ");
                            this.model.setNum1(Convert.ToInt32(Console.ReadLine()));
                            Console.WriteLine("A Raiz do Segundo numero é: " + this.model.raizSegundoNumero());
                        break;
                        case 8:
                            Console.WriteLine("Informe um numero: ");
                            int num = Convert.ToInt32(Console.ReadLine());
                            //Para chamar a tabuada
                            Console.WriteLine(this.model.tabuada(num));
                        break;
                        case 9:
                            Console.WriteLine("Informe um numero: ");
                            int ano = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(this.model.bissexto(ano));
                        break;
                        case 10:
                            Console.WriteLine("Informe um numero: ");
                            int verificar = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(this.model.verificarNum(verificar));
                        break;
                        case 11:
                            Console.WriteLine("Informe a idade:");
                            int idade = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(this.model.verificarIdade(idade));
                        break;
                        case 12:
                            Console.WriteLine("Informe um número: ");
                            int intervalo = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Informe o primerio numero do intervalo: ");
                            int intervaloComeco = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Informe o segundo numero do intervalo: ");
                            int intervaloFinal = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine(this.model.verificarIntervalo(intervalo, intervaloComeco, intervaloFinal));

                        break;

                        //exercicio 14
                        case 14:
                            Console.WriteLine(this.model.definirMaiorMenor());
                        break;
                            default:
                                Console.WriteLine("Informe um valor correto!!");
                            break;
                }//fim do escolha
            }while(opcao != 0);
        }//fim do metodo

        public void coletar() 
        {
            Console.Write("\nInforme o primeiro numero:");
            this.model.setNum1(Convert.ToDouble(Console.ReadLine()));//peguei o primeiro numero

            Console.Write("Informe o segundo numero:");
            this.model.setNum2 (Convert.ToDouble(Console.ReadLine()));//peguei o segundo numero
        }
    }//fim da classe
}//fim do projeto
