using System;

namespace _1_TypyGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            //KolejkaKolowa<double> kolejka = new KolejkaKolowa<double>(6);
            //var kolejkaInt = new KolejkaKolowa<int>();
            //var kolejkaString = new KolejkaKolowa<string>();

            //var kolejkaOsob = new KolejkaKolowa<Osoba>();
            //kolejkaOsob.Zapisz(new Osoba { Imie = "Marcin", Nazwisko = "Test" });
            //kolejkaOsob.Zapisz(new Osoba { Imie = "Tomek", Nazwisko = "Test" });
            //kolejkaOsob.Zapisz(new Osoba { Imie = "Jacek", Nazwisko = "Test" });
            //kolejkaOsob.Zapisz(new Osoba { Imie = "Konrad", Nazwisko = "Test" });

            //while (!kolejkaOsob.JestPusty)
            //{
            //    //var wynik = kolejkaOsob.Czytaj().Imie;
            //    Console.WriteLine("\t" + kolejkaOsob.Czytaj()+"\t");                
            //}

            //console.writeline("wprowadz dane do kolejki:");
            var kolejka = new KolejkaKolowa<double>();

            WprowadzanieDanych(kolejka);
            PrzetwarzanieDanych(kolejka);
        }

        private static void PrzetwarzanieDanych(KolejkaKolowa<double> kolejka)
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

        private static void WprowadzanieDanych(KolejkaKolowa<double> kolejka)
        {
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
    //public class Osoba
    //{
    //    public string Imie { get; set; }
    //    public string Nazwisko { get; set; }
    //}
}
