using System;
using System.Collections.Generic;

namespace _2_KolekcjeGeneryczne
{
    class Program2_1_Kolejka
    {
        static void MainKolejka(string[] args)
        {
            Queue<Pracownik> kolejka = new Queue<Pracownik>();
            kolejka.Enqueue(new Pracownik { Imie = "Marcin", Nazwisko = "Nowak" });
            kolejka.Enqueue(new Pracownik { Imie = "Jan", Nazwisko = "Janowski" });
            kolejka.Enqueue(new Pracownik { Imie = "Jacek", Nazwisko = "Kowalski" });
            kolejka.Enqueue(new Pracownik { Imie = "Ola", Nazwisko = "Kaczor" });

            while(kolejka.Count > 0)
            {
                var pracownik = kolejka.Dequeue();
                Console.WriteLine(pracownik.Nazwisko+" "+pracownik.Imie);
            }
            
        }
    }
}
