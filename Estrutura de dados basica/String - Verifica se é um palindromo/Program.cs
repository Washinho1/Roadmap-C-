using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String___Verifica_se_é_um_palindromo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Phrase;

            Console.WriteLine("Digite a frase que deseja verificar");
            Phrase = Console.ReadLine();

            string cleanPhrase = Phrase.Trim().Replace(" ", "");

            char[] Changeposition = cleanPhrase.ToCharArray();
            Array.Reverse(Changeposition);
            string reversedPhrase = new string(Changeposition);

            if (reversedPhrase == cleanPhrase)
            {

                Console.WriteLine($"A palavra/frase \"{Phrase}\" é um palindromo");

            }
            else {
                Console.WriteLine($"A palavra/frase \"{Phrase}\" nao é um palindromo");
            }

        }
    }
}
