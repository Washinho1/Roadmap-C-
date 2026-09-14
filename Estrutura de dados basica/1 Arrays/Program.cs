using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] notas = new int[5];

            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine("escreva a nota " + (i + 1));
                notas[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < notas.Length; i++) {
                for (int j = i + 1; j < notas.Length; j++)
                {
                    if (notas[i] > notas[j])
                    {
                        int temp = notas[i];
                        notas[i] = notas[j];
                        notas[j] = temp;
                    }
                }
            }

            Console.WriteLine("A maior nota foi : " + notas[4]);
            Console.WriteLine("A menor nota foi : " + notas[0]);
            Console.WriteLine("A nota do meio foi : " + notas[2]);
        }
    }
}
