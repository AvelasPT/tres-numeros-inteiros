using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace três_números_inteiros
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, media, soma;

            Console.Write("Introduza o 1º nº: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Introduza o 2º nº: ");
            n2 = int.Parse(Console.ReadLine());

            Console.Write("Introduza o 3º nº: ");
            n3 = int.Parse(Console.ReadLine());

            soma = n1 + n2 + n3;
            media = soma / 3; 

            if(n1 > n2 && n2 > n3)
            {
                Console.WriteLine("O maior número é o " + n1 + " e o menor é " + n3 + ".");
            }
            else if(n1>n3 && n3>n2)
            {
                Console.WriteLine("O maior número é o " + n1 + " e o menor é " + n2 + ".");
            }
            else if (n2 > n1 && n1 > n3)
            {
                Console.WriteLine("O maior número é o " + n2 + " e o menor é " + n3 + ".");
            }
            else if (n2 > n3 && n3 > n1)
            {
                Console.WriteLine("O maior número é o " + n2 + " e o menor é " + n1 + ".");
            }
            else if (n3 > n1 && n1 > n2)
            {
                Console.WriteLine("O maior número é o " + n3 + " e o menor é " + n2 + ".");
            }
            else
            {
                Console.WriteLine("O maior número é o " + n3 + " e o menor é " + n1 + ".")
            }
            Console.WriteLine("A soma entre os 3 números dá " + soma + " e a media deles dá " + media + ".");
            Console.ReadKey();
        }
    }
}
