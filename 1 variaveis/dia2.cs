using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 0;
            string nome = null;

            Console.WriteLine("Me diga o seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Me diga a sua idade");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("seu nome é " + nome + " e sua idade daqui a 10 anos vai ser " + (idade + 10) );
        }
    }
}
