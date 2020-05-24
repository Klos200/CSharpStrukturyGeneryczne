using System;
using System.Collections.Generic;

namespace _2_KolekcjeGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lista();
            //Tablica();
            //Kolejka();
            //Stos();
            //HashSet();
            //LinkedList();
            //Dictionary();
            //DictionaryAdvance();
            //SortedDictionary();
            //SortedList();
            var set = new SortedSet<int>();
            set.Add(8);
            set.Add(6);
            set.Add(5);
            set.Add(3);
            set.Add(2);
            set.Add(1);
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
            var set2 = new SortedSet<string>();
            set2.Add("t");
            set2.Add("a");
            set2.Add("1");
            set2.Add("b");
            set2.Add("c");
            set2.Add("_");
            foreach (var item in set2 )
            {
                Console.WriteLine(item);
            }

        }

        private static void SortedList()
        {
            var listaPosortowana = new SortedList<int, string>();
            listaPosortowana.Add(3, "trzy");
            listaPosortowana.Add(1, "jeden");
            listaPosortowana.Add(4, "cztery");
            listaPosortowana.Add(2, "dwa");
            foreach (var item in listaPosortowana)
            {
                Console.WriteLine(item);
            }
        }

        private static void SortedDictionary()
        {
            var pracownicy = new SortedDictionary<string, List<Pracownik>>();
            pracownicy.Add("Sprzedaż", new List<Pracownik> { new Pracownik { Imie = "Jan", Nazwisko = "Nowak" },
                                                             new Pracownik { Imie = "Kuba", Nazwisko = "Kowal" },
                                                             new Pracownik { Imie = "Jarosław", Nazwisko = "Węg" }});
            pracownicy.Add("Informatyka", new List<Pracownik> { new Pracownik { Imie = "Jakub", Nazwisko = "Szczygieł" },
                                                                new Pracownik { Imie = "Piotr", Nazwisko = "Negtg" }});
            pracownicy.Add("Księgowość", new List<Pracownik> { new Pracownik { Imie = "Janina", Nazwisko = "Szczygieł" },
                                                               new Pracownik { Imie = "Marlena", Nazwisko = "Kowal" },
                                                               new Pracownik { Imie = "Paulina", Nazwisko = "Kłosowska" },
                                                               new Pracownik { Imie = "Urszula", Nazwisko = "Kłosowska" }});
            foreach (var item in pracownicy)
            {
                Console.WriteLine("Ilość pracowników w dziale {0} wynosi {1}", item.Key, item.Value.Count);
            }
        }

        private static void DictionaryAdvance()
        {
            var pracownicy = new Dictionary<string, List<Pracownik>>();
            pracownicy.Add("Ksiegowosc", new List<Pracownik>() { new Pracownik { Imie = "Marcin", Nazwisko = "Nowak" },
                                                                 new Pracownik { Imie = "Jan", Nazwisko = "Nowak" },
                                                                 new Pracownik { Nazwisko = "Nowak", Imie = "Jakub" }});

            pracownicy["Ksiegowosc"].Add(new Pracownik { Nazwisko = "Testowy", Imie = "Jan" });
            pracownicy.Add("Informatyka", new List<Pracownik>() { new Pracownik { Imie = "Sebastian", Nazwisko = "Bogacki" },
                                                                 new Pracownik { Imie = "Rafał", Nazwisko = "Nowak" } });


            foreach (var item in pracownicy)
            {
                Console.WriteLine("Dział " + item.Key);
                foreach (var pracownik in item.Value)
                {
                    Console.WriteLine("{0} {1}", pracownik.Nazwisko, pracownik.Imie);
                }
                Console.WriteLine("");

            }
            Console.WriteLine("Pracownicy z księgowości");
            foreach (var item in pracownicy["Ksiegowosc"])
            {
                Console.WriteLine("{0} {1}", item.Nazwisko, item.Imie);
            }
        }

        private static void Dictionary()
        {
            var pracownicy = new Dictionary<string, Pracownik>();
            pracownicy.Add("Nowak", new Pracownik { Imie = "Marcin", Nazwisko = "Nowak" });
            pracownicy.Add("Kowal", new Pracownik { Imie = "Tomek", Nazwisko = "Kowal" });
            pracownicy.Add("Kaczor", new Pracownik { Imie = "Jan", Nazwisko = "Kaczor" });

            var kowal = pracownicy["Kowal"];
            foreach (var pracownik in pracownicy)
            {
                Console.WriteLine(pracownik.Value.Nazwisko + " " + pracownik.Value.Imie);
                Console.WriteLine("{0}:{1}", pracownik.Key, pracownik.Value.Nazwisko);
            }
        }

        private static void LinkedList()
        {
            LinkedList<int> lista = new LinkedList<int>();
            lista.AddFirst(5);
            lista.AddFirst(4);
            lista.AddFirst(3);
            lista.AddLast(6);

            LinkedListNode<int> pozycja1 = lista.Find(6);
            lista.AddAfter(pozycja1, 7);
            lista.AddAfter(pozycja1.Next, 8);

            var pozycja2 = lista.Find(3);
            lista.AddBefore(pozycja2, 2);
            lista.AddBefore(pozycja2.Previous, 1);
                        
            var wezel = lista.First;
            while (wezel != null)
            {
                Console.WriteLine(wezel.Value);
                wezel = wezel.Next;
            }
        }

        private static void HashSet()
        {
            HashSet<Pracownik> set = new HashSet<Pracownik>();

            var pracownik = new Pracownik { Imie = "Marcin", Nazwisko = "Nowak" };
            set.Add(pracownik);
            set.Add(pracownik);


            foreach (var item in set)
            {
                Console.WriteLine(item.Imie);
            }
        }

        private static void Stos()
        {
            Stack<Pracownik> stos = new Stack<Pracownik>();
            stos.Push(new Pracownik { Imie = "Marcin", Nazwisko = "Nowak" });
            stos.Push(new Pracownik { Imie = "Jan", Nazwisko = "Janowski" });
            stos.Push(new Pracownik { Imie = "Jacek", Nazwisko = "Kowalski" });
            stos.Push(new Pracownik { Imie = "Ola", Nazwisko = "Kaczor" });

            Console.WriteLine("");
            Console.WriteLine("STOS");
            while (stos.Count > 0)
            {
                var pracownik = stos.Pop();
                Console.WriteLine(pracownik.Nazwisko + " " + pracownik.Imie);
            }
        }

        private static void Kolejka()
        {
            Queue<Pracownik> kolejka = new Queue<Pracownik>();
            kolejka.Enqueue(new Pracownik { Imie = "Marcin", Nazwisko = "Nowak" });
            kolejka.Enqueue(new Pracownik { Imie = "Jan", Nazwisko = "Janowski" });
            kolejka.Enqueue(new Pracownik { Imie = "Jacek", Nazwisko = "Kowalski" });
            kolejka.Enqueue(new Pracownik { Imie = "Ola", Nazwisko = "Kaczor" });

            Console.WriteLine("KOLEJKA");
            while (kolejka.Count > 0)
            {
                var pracownik = kolejka.Dequeue();
                Console.WriteLine(pracownik.Nazwisko + " " + pracownik.Imie);
            }
        }

        private static void Tablica()
        {
            Pracownik[] pracownicy = new Pracownik[]
                        {
                new Pracownik { Imie = "Marcin", Nazwisko = "Nowak" },
                new Pracownik { Imie = "Jan", Nazwisko = "Nowak" },
                new Pracownik { Imie = "Tomek", Nazwisko = "Nowak" },
                        };

            foreach (var pracownik in pracownicy)
            {
                Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            }
            for (int i = 0; i < pracownicy.Length; i++)
            {
                Console.WriteLine(pracownicy[i].Imie + " " + pracownicy[i].Nazwisko);
            }
            Array.Resize(ref pracownicy, 10);
            pracownicy[9] = new Pracownik { Imie = "Antek", Nazwisko = "Koszyl" };
        }

        private static void Lista()
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
            //while (true)
            //{
            //    if (liczby.Capacity != pojemnosc)
            //    {
            //        pojemnosc = liczby.Capacity;
            //        Console.WriteLine(pojemnosc);
            //    }
            //    liczby.Add(1);
            //}
        }
    }
}

