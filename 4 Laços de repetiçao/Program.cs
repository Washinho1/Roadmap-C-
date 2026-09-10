using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laços_de_repetiçao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;

            Console.WriteLine("Digite a tabuada que deseja receber \n");
            num1 = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(num1 + " x " + i + " = " + i * num1);

            }
            Console.ReadLine();
        }
    }
}
