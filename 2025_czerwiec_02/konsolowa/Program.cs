using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konsolowa
{
    public class Program
    {
        public static string Szyfruj(string text, int key)
        {
            string newText = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    newText += ' ';
                    continue;
                }

                int newCharNumber = (char)text[i] + key;
                if (newCharNumber > 122)
                    newCharNumber = 97 + (newCharNumber - 123);
                else if (newCharNumber < 97)
                    newCharNumber = 122 - (96 - newCharNumber);
                newText += Convert.ToChar(newCharNumber);
            }

            return newText;
        }

        static void Main(string[] args)
        {
            Console.Write("Podaj tekst: ");
            string tekst = Console.ReadLine();
            Console.Write("Podaj klucz: ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Szyfruj(tekst, k));
        }
    }
}
