using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konsolowa
{
    public class Kosc
    {
        public Kosc()
        {
            Random rand = new Random();
            int number = rand.Next(6) + 1;

            value = number;
            imageIndex = number;
            available = true;
            instancesCount++;
        }

        public Kosc(int v)
        {
            if (v < 1 || v > 6)
                value = 0;
            else
                value = v;

            imageIndex = v;
            available = true;
            instancesCount++;
        }

        public void Rzuc()
        {
            if (!available)
                return;

            Random rand = new Random();
            int number = rand.Next(6) + 1;

            value = number;
            imageIndex = number;
        }

        public void Disable()
        {
            available = false;
        }

        public string GetValueToString()
        {
            switch(value)
            {
                case 0:
                    return "zero";
                case 1:
                    return "jeden";
                case 2:
                    return "dwa";
                case 3:
                    return "trzy";
                case 4:
                    return "cztery";
                case 5:
                    return "pięć";
                case 6:
                    return "sześć";
            }

            return "zła wartość";
        }

        static public int instancesCount = 0;
        public string[] images = { "kosc0.png", "kosc1.png", "kosc2.png", "kosc3.png", "kosc4.png", "kosc5.png", "kosc6.png"   };
        public int value = 0;
        public int imageIndex = 0;
        public bool available = false;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Kosc kosc1 = new Kosc();
            Console.WriteLine("Instancje: " + Kosc.instancesCount);
            Console.WriteLine("Wyrzucono: " + kosc1.value + ", " + kosc1.GetValueToString());
            Console.WriteLine("Plik: " + kosc1.images[kosc1.imageIndex]);

            Console.WriteLine();
            Console.WriteLine("Podaj wartość kości: ");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Kosc kosc2 = new Kosc(value);
            Console.WriteLine("Instancje: " + Kosc.instancesCount);
            Console.WriteLine("Wyrzucono: " + kosc2.value + ", " + kosc2.GetValueToString());
            Console.WriteLine("Plik: " + kosc2.images[kosc2.imageIndex]);
        }
    }
}
