namespace _1_TypyGeneryczne
{
    class KolejkaKolowa
    {
        private double[] bufor;
        private int poczatekBufora;
        private int koniecBufora;

        public KolejkaKolowa() : this(pojemnosc: 5)
        {

        }
        public KolejkaKolowa(int pojemnosc)
        {
            bufor = new double[pojemnosc + 1];
            poczatekBufora = 0;
            koniecBufora = 0; 
        } 
        public void Zapisz(double wartosć)
        {
            bufor[koniecBufora] = wartosć;
            koniecBufora = (koniecBufora + 1) % bufor.Length;
            if (koniecBufora == poczatekBufora)
                poczatekBufora = (poczatekBufora + 1) % bufor.Length;
        }

        public double Czytaj()
        {
            var wynik = bufor[poczatekBufora];
            poczatekBufora = (poczatekBufora + 1) % bufor.Length;
            return wynik;
        }
        //właściwośc
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
