namespace _1_TypyGeneryczne
{
    public class KolejkaKolowa
    {
        private double[] bufor;
        private int poczatekBufora;
        private int koniecBufora;

        //Konstruktory
        public KolejkaKolowa() : this(pojemnosc: 5)
        {

        }
        public KolejkaKolowa(int pojemnosc)
        {
            bufor = new double[pojemnosc + 1];
            poczatekBufora = 0;
            koniecBufora = 0; 
        } 
        //Metody
        public void Zapisz(double wartosć)
        {
            bufor[koniecBufora] = wartosć; //0 - 1; 1 - 2; 2 - 3 ; 3
            koniecBufora = (koniecBufora + 1) % bufor.Length;// po pierwszym obiegu =1, po drugim = 2, pod trzecim =3 
            if (koniecBufora == poczatekBufora)
                poczatekBufora = (poczatekBufora + 1) % bufor.Length;
        }

        public double Czytaj()
        {
            var wynik = bufor[poczatekBufora];
            poczatekBufora = (poczatekBufora + 1) % bufor.Length;
            return wynik;
        }
        //właściwości
        public int Pojemonosc
        {
            get
            {
                return bufor.Length;
            }
        }
        public bool JestPusty
        {
            get
            {
                return koniecBufora == poczatekBufora;
            }
        }
        public bool JestPelny
        {
            get
            {
                return (koniecBufora + 1) % bufor.Length == poczatekBufora;
            }
        }

    }
}
