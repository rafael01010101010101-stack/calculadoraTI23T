using System;
using System.Collections.Generic;
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
            return "--------Menu--------\n\n"       +
                "Escolha uma das opções abaixo: \n" +
                "0. Sair\n"                         +
                "1. Somar\n"                        +
                "2. Subtrair\n"                     +
                "3. Multiplicar\n"                  +
                "4. Dividir\n"                      +
                "5. Potência\n";                
        }//fim do metodo

        public void realizarOperacao() 
        {
            int opcao = 0;//declarar do lado de fora do do...wrile()
            do
            {
                Console.WriteLine(this.mostrarMenu());//chamar menu
                opcao = Convert.ToInt32(Console.ReadLine());//leia
                if (opcao != 0) 
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
