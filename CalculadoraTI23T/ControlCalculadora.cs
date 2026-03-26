using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
                "13. Verifique oque é o triangulo\n"+
                "14. Leia um número de 1 a 7 e diga o dia da semana\n"+
                "15. Verifique se a senha digital é válida\n"+
                "16. Leia dois horarios e diga qual o maior\n"+
                "17. Leia dois numero e diga o maior\n"+
                "18. Leia 5 numeros e calcule a média\n"+
                "19. Leia numeros ate que a soma ultrapasse 100\n"+
                "20. Solicite senhas ate que a valida senha informada\n"+
                "21. Leia 10 numeros e exiba o maior e o menor\n"+
                "22. Leia uma idade e diga se é criança, adolescente, adulto ou idoso";
                
        }//fim do metodo

        public void realizarOperacao() 
        {
            int opcao = 0;//declarar do lado de fora do do...wrile()
            do
            {
                Console.WriteLine(this.mostrarMenu());//chamar menu
                opcao = Convert.ToInt32(Console.ReadLine());//leia
                if (opcao != 0 && opcao !=6 && opcao !=7 && opcao !=8 && opcao !=9 && opcao != 10 && opcao !=11 && opcao !=12 && opcao !=13 && opcao !=14 && opcao !=15 && opcao != 16
                    && opcao != 17 && opcao != 18 && opcao != 19 && opcao != 20 && opcao != 21 && opcao != 22 && opcao !=23) 
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

                        case 13:
                            Console.WriteLine("Informe o valor do primeiro lado do triangulo: ");
                            double lado1 = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Informe o valor do segundo lado do triangulo: ");
                            double lado2 = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Informe o valor do terceiro lado do triangulo: ");
                            double lado3 = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine(this.model.triangulo(lado1, lado2, lado3));
                        break;

                        case 14:
                            Console.WriteLine("Informe um Valor de 1 a 7: ");
                            int num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.model.semana(num1));
                        break;

                        case 15:
                            Console.WriteLine("Informe a senha: ");
                            string senha1 = Console.ReadLine();
                            Console.WriteLine("Informe a senha novamente: ");
                            string senha2 = Console.ReadLine();
                            Console.WriteLine(this.model.senha(senha1, senha2));
                        break;

                        case 16:
                            Console.WriteLine("Informe o primeiro horario: ");
                            DateTime horario1 = Convert.ToDateTime(Console.ReadLine());
                            Console.WriteLine("Informe o segundo horario: ");
                            DateTime horario2 = Convert.ToDateTime(Console.ReadLine());
                            Console.WriteLine(this.model.horarios(horario1, horario2));
                        break;

                        case 17:
                            Console.WriteLine("Informe um numero: ");
                            double num11 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Informe o segundo numero: ");
                            double num22 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(this.model.numeros(num11, num22));
                        break;

                        case 18:
                        Console.WriteLine("Informe o primeiro numero: ");
                        double num01 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe o segundo numero: ");
                        double num02 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe o terceiro numero: ");
                        double num03 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe o quarto numero: ");
                        double num04 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe o quinto numero: ");
                        double num05 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.model.media(num01, num02, num03, num04, num05));
                        break;

                        case 19:
                            Console.WriteLine("Informe um numero: ");
                            double num011 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(this.model.numerosAteCem(num011));
                        break;

                        case 20:
                           this.model.senhas("", "");
                        break;

                        case 21:
                            Console.WriteLine(this.model.definirMaiorMenor());
                        break;

                        case 22:
                            Console.WriteLine("Informe uma idade: ");
                            int idade1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(this.model.idade(idade1));
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
