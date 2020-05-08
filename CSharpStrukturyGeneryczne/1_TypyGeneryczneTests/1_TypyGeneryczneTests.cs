using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1_TypyGeneryczne;

namespace _1_TypyGeneryczneTests
{
    [TestClass]
    public class KolejkaKolowaTests
    {
        [TestMethod]
        public void NowaKolejkaJestPusta()
        {
            var kolejka = new KolejkaKolowa();

            Assert.IsTrue(kolejka.JestPusty);
        }
        [TestMethod]
        public void KolejkaTrzyElementowaJestPelnaPoTrzechZapisach()
        {
            var kolejka = new KolejkaKolowa(3);
            kolejka.Zapisz(1.0);
            kolejka.Zapisz(1.1);
            kolejka.Zapisz(1.2);
            Assert.IsTrue(kolejka.JestPelny);
        }
        [TestMethod]
        public void PierwszyWchodziPierwszyWychodzi()
        {
            var kolejka = new KolejkaKolowa(pojemnosc : 3);
            var wartosc1 = 1.6;
            var wartosc2 = 2.6;
            kolejka.Zapisz(wartosc1);
            kolejka.Zapisz(wartosc2);
            Assert.AreEqual(wartosc1, kolejka.Czytaj());
            Assert.AreEqual(wartosc2, kolejka.Czytaj());
            Assert.IsTrue(kolejka.JestPusty);
        }
        [TestMethod]
        public void NadpisujeGdyJestWiekszaNizPojemnosc()
        {
            var kolejka = new KolejkaKolowa(pojemnosc: 3);
            var wartosci = new[] { 1.2, 2.4, 3.6, 4.8, 6.0, 7.2 };
            foreach (var wartosc in wartosci)
            {
                kolejka.Zapisz(wartosc);
            }
            Assert.IsTrue(kolejka.JestPelny);
            Assert.AreEqual(wartosci[3], kolejka.Czytaj());
            Assert.AreEqual(wartosci[4], kolejka.Czytaj());
            Assert.AreEqual(wartosci[5], kolejka.Czytaj());
            Assert.IsTrue(kolejka.JestPusty);
        }
    }
}
