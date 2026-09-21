using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace List___To_do_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> toDoList = new List<string>();

            int choice = -1;

            while (choice != 0)
            {

                Console.WriteLine("Selecione o que deseja fazer");
                Console.WriteLine("1 - Adicionar item a lista");
                Console.WriteLine("2 - Remover item da lista");
                Console.WriteLine("3 - Listar todos os itens");
                Console.WriteLine("0 - Sair do app");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.Clear();
                    Console.WriteLine("Opçao invalida! digite apenas um numero");
                    continue;
                }

                switch (choice)
                {
                    case 0:
                        choice = 0;
                        break;
                    case 1:
                        Console.WriteLine("O Que deseja adicionar a lista?");
                        toDoList.Add(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("foi adicionado com sucesso \n");
                        break;
                    case 2:
                        Console.WriteLine("Qual item  vc deseja remover?");
                        toDoList.Remove(Console.ReadLine());
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Sua lista contem:");
                        foreach (string toDo in toDoList)
                        {
                            Console.WriteLine(toDo);
                        }
                        Console.WriteLine("\n Digite qualqeur coisa pra voltar ao menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
