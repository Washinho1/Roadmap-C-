using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicionario___Agenda_de_contatos_que_busca_por_nome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var contacts = new Dictionary<string, string>();

            contacts.Add("joao", "21978785454");
            contacts.Add("paola", "21985853424");
            contacts.Add("marcelo", "19987543221");

            Console.WriteLine("Qual o contato que deseja buscar?");
            string searchOriginal = Console.ReadLine();
            string search = searchOriginal.ToLower();

            if (contacts.ContainsKey(search))
            {
                Console.WriteLine(contacts[search]);
            }
            else
            {
                Console.WriteLine("Esse contato nao existe");
                Console.WriteLine("Deseja adicionar? 1 Sim - 2 Nao");

                string choiceOriginal = Console.ReadLine();
                int choice;

                bool right = int.TryParse(choiceOriginal, out choice);

                if (choice == 1)
                {
                    Console.WriteLine("\nQual o numero dessa pessoa?");
                    contacts.Add(search, Console.ReadLine());
                    Console.WriteLine("\nContato adicionado com sucesso");
                }
                else if (choice == 2) {
                    Console.WriteLine("\nO contato nao sera adicionado, segue a lista de contatos existentes");
                }

                else {
                    Console.WriteLine("\nNao foi escolhido um numero correto");
                }
            }
            foreach (var contact in contacts)
            {
                Console.WriteLine($"\nNome {contact.Key} - numero : {contact.Value}");
            }
        }
    }
}
