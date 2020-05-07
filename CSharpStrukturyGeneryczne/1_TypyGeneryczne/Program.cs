using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_TypyGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            KolejkaKolowa kolejka = new KolejkaKolowa(3);
            Console.WriteLine("Wprowadz dane do kolejki:");
            Console.WriteLine(kolejka.Pojemonosc);
            while (true)
            {
                var wartoscWejsciowa = Console.ReadLine();
                var wartosc = 0.0;
                if (double.TryParse(wartoscWejsciowa, out wartosc))
                {
                    kolejka.Zapisz(wartosc);
                    continue;
                }
                break;                       
            }
            Console.WriteLine("w naszej kolejce jest:");
            while(!kolejka.JestPusty)
            {
                Console.WriteLine("\t\t"+kolejka.Czytaj());
            }
        }
    }
}
