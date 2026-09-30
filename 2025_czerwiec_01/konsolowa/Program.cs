using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konsolowa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ile wygenerować losowań?");
            int num = Convert.ToInt32(Console.ReadLine());

            List<List<int>> zestawy = new List<List<int>>();
            int[] count = new int[49];
            Random rand = new Random();

            Console.WriteLine("Zestawy wylosowanych liczb:");
            for (int i = 0; i < num; i++)
            {
                Console.Write("Losowanie " + (i+1) + ": ");

                List<int> zestaw = new List<int>();
                for (int j = 0; j < 6; j++)
                {
                    int randNum = rand.Next(49) + 1;

                    zestaw.Add(randNum);
                    count[randNum - 1]++;

                    Console.Write(randNum + " ");
                }

                zestawy.Add(zestaw);
                Console.WriteLine();
            }

            for (int i = 0; i < 49; i++)
            {
                Console.WriteLine("Wystąpienia liczby " + (i+1) + ": " + count[i]);
            }
        }
    }
}
