using System.Collections.Generic;

namespace _3_KlasyInterfejsGeneryczne
{
    public class DuzaKolejka<T> : IKolejka<T>
    {

        protected Queue<T> kolejka;

        public DuzaKolejka()
        {
            kolejka = new Queue<T>();
        }

        public virtual bool JestPusty
        {
            get
            {
                return kolejka.Count == 0;
            }
        }

        public virtual bool JestPelny => throw new System.NotImplementedException();

        public virtual T Czytaj()
        {
            return kolejka.Dequeue();
        }

        public virtual void Zapisz(T wartosc)
        {
            kolejka.Enqueue(wartosc);
        }
        public virtual void Czysc ()
        {
            kolejka.Clear();
        }
    }
}