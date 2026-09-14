using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia_4_Estruturas_condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nota;

            Console.WriteLine("Digite a nota do aluno");
            nota = int.Parse(Console.ReadLine());

            if (nota >= 9)
            {
                Console.WriteLine("Aluno tirou nota A");
            }
            else if (nota >= 7)
            {
                Console.WriteLine("Aluno tirou nota B");
            }
            else if (nota >= 5)
            {
                Console.WriteLine("Aluno tirou nota C");
            }
            else
            {
                Console.WriteLine("Aluno tirou nota F");
            }
        }
        }
    }
