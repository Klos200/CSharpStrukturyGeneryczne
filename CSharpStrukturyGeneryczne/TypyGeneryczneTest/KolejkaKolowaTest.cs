using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1_TypyGeneryczne;

namespace _1_TypyGeneryczneTest
{
    [TestClass]
    public class KolejkaKolowaTest
    {
        [TestMethod]
        public void NowaKolejkaJestPusta()
        {
            var kolejka = new KolejkaKolowa();
        }
    }
}
