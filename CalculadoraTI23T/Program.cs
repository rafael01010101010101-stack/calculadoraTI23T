using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTI23T
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Passando os dois numeros para a classe de controle
            ControlCalculadora controle = new ControlCalculadora();

            controle.realizarOperacao();//executa as ações
            Console.ReadLine();//manter o prompt aberto
        }//fim do método main
    }//fim da classe progam
}//fim do projeto Calculadora TI23T