using System;

namespace _3_KlasyInterfejsGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            //var kolejka = new DuzaKolejka<double>();
            //WprowadzanieDanych(kolejka);
            //PrzetwarzanieDanych(kolejka);
            //WprowadzanieDanych(kolejka);
            //Czysc(kolejka);
            //PrzetwarzanieDanych(kolejka);

            var kolejka = new KolejkaKolowa<double>(3);            
            WprowadzanieDanych(kolejka);
            PrzetwarzanieDanych(kolejka);
            Console.WriteLine(kolejka.JestPelny);
        }

        private static void Czysc(DuzaKolejka<double> kolejka)
        {
            Console.WriteLine("Czyszczę Kolejkę");
            kolejka.Czysc();
        }

        private static void PrzetwarzanieDanych(IKolejka<double> kolejka)
        {
            var suma = 0.0;
            Console.WriteLine("w naszej kolejce jest:");
            while (!kolejka.JestPusty)
            {
                suma += kolejka.Czytaj();
                //                console.writeline("\t\t"+kolejka.czytaj());                
            }
            Console.WriteLine("suma\t\t" + suma);
        }

        private static void WprowadzanieDanych(IKolejka<double> kolejka)
        {
            Console.WriteLine("Wprowadź cyfry (inny znak zatrzymuje wprowadzanie");
            while (true)
            {
                var wartosc = 0.0;
                var wartoscwejsciowa = Console.ReadLine();
                if (double.TryParse(wartoscwejsciowa, out wartosc))
                {
                    kolejka.Zapisz(wartosc);
                    continue;
                }
                break;
            }
        }
    }
}
