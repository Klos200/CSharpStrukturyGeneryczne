using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2_KolekcjeGeneryczneTest
{
    [TestClass]
    public class LinkedListTest
    {
        [TestMethod]
        public void DodawaniePoElemencie()
        {
            var lista = new LinkedList<string>();

            lista.AddFirst("Marcin");
            lista.AddLast("Tomek");
            lista.AddAfter(lista.First, "Ola");
            var pozycja = lista.Find("Ola");
            Assert.AreEqual("Ola", pozycja.Value);
            Assert.AreEqual("Ola", lista.First.Next.Value);
        }
        [TestMethod]
        public void DodawaniePrzedElementem()
        {
            var lista = new LinkedList<string>();

            lista.AddFirst("Marcin");
            lista.AddLast("Tomek");
            lista.AddBefore(lista.First, "Ola");
            Assert.AreEqual("Ola", lista.First.Value);
        }
        [TestMethod]
        public void UsuwanieElementuOstatniego()
        {
            var lista = new LinkedList<string>();

            lista.AddFirst("Marcin");
            lista.AddLast("Tomek");
            lista.RemoveLast();
            Assert.AreEqual(lista.First, lista.Last);
            Assert.AreEqual(1, lista.Count);
        }
        [TestMethod]
        public void UsuwanieElementu()
        {
            var lista = new LinkedList<string>();

            lista.AddFirst("Marcin");
            lista.AddLast("Tomek");
            lista.Remove("Tomek");
            Assert.AreEqual(lista.First, lista.Last);
            Assert.AreEqual(1, lista.Count);
            Assert.AreEqual("Marcin", lista.First.Value);
        }
        [TestMethod]
        public void  CzyListaZawiera()
        {
            var lista = new LinkedList<string>();

            lista.AddFirst("Marcin");
            lista.AddLast("Tomek");
            Assert.IsTrue(lista.Contains("Marcin"));
        }
        [TestMethod]
        public void CzyszczenieListy()
        {
            var lista = new LinkedList<string>();

            lista.AddFirst("Marcin");
            lista.AddLast("Tomek");
            lista.Clear();
            Assert.AreEqual(0, lista.Count);
        }
    }
}

