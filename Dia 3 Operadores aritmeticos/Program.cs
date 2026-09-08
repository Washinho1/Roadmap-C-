using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("escolha o primeiro numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("escola o segundo numero");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("A soma dos dois daria: " +  (num1 + num2));
            Console.WriteLine("A subtraçao dos dois daria: " + (num1 - num2));
            Console.WriteLine("A divisao entre os dois daria: " + (num1 / num2));
            Console.WriteLine("A multiplicaçao entre os dois daria: " + (num1 * num2));

        }
    }
}
