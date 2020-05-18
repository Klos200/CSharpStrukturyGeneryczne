using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_KolekcjeGeneryczne
{
    class Program2_1_Lista
    {
        static void Main(string[] args)
        {
            List<Pracownik> pracownicy = new List<Pracownik>
            {
                new Pracownik { Imie = "Marcin", Nazwisko = "Nowak" },
                new Pracownik { Imie = "Jan", Nazwisko = "Nowak" },
                new Pracownik { Imie = "Tomek", Nazwisko = "Nowak" },
            };

            foreach (var pracownik in pracownicy)
            {
                Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            }
            pracownicy.Add(new Pracownik { Imie = "Antek", Nazwisko = "Koszyl" });
            for (int i = 0; i < pracownicy.Count; i++)
            {
                Console.WriteLine(pracownicy[i].Imie + " " + pracownicy[i].Nazwisko);
            }

            var liczby = new List<int>();
            var pojemnosc = -1;
            while (true)
            {
                if (liczby.Capacity != pojemnosc)
                {
                    pojemnosc = liczby.Capacity;
                    Console.WriteLine(pojemnosc);
                }
                liczby.Add(1);


            }

        }
    }
}
