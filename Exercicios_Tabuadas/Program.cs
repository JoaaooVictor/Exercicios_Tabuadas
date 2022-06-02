using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Tabuadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // RA: 6320031
            // NOME: JOÃO VICTOR DE LIMA SILVEIRA



            // (Exercicio 1)


            int produto, mult = 0, valor, valor2;

            Console.Write("Digite um número para saber suas multiplicações: ");
            valor = Convert.ToInt32(Console.ReadLine());
            Console.Write("Até qual número deseja visualizar: ");
            valor2 = Convert.ToInt32(Console.ReadLine());

            while (mult <= valor2)
            {
                produto = valor * mult;
                Console.WriteLine(valor + " x " + mult + " = " + produto);
                mult = mult + 1;
            }
            Console.ReadKey();



            // (Exercicio 2)


            int produto, mult = 10, valor;

            Console.Write("Digite um número para saber suas multiplicações:");
            valor = Convert.ToInt32(Console.ReadLine());

            while (mult <= 10 && mult >= 0)
            {
                produto = valor * mult;
                Console.WriteLine(valor + " x " + mult + " = " + produto);
                mult = mult - 1;
            }
            Console.ReadKey();


            // (Exercicio 3)


            int produto, mult = 0, op = 0;


            while (mult <= 10)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("Tabuada = " + mult);
                Console.WriteLine("---------------------------");

                while (op <= 10)
                {
                    produto = mult * op;
                    Console.WriteLine(mult + " x " + op + " = " + produto);
                    op = op + 1;
                }
                mult = mult + 1;
                op = op - 10;

                //}


            }
    }
}
