using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProyectoPruebas
{
    [TestClass]
    public class UnitTest1
    {
        private int[] vesp = new int[] { 1, 2, 3, 4, 5 };
        private Burbuja burbu = new Burbuja();

        [TestMethod]
        public void ordenado()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            burbu.ordenar(arr);
            CollectionAssert.AreEqual(vesp, arr);
        }

        [TestMethod]
        public void intercambiado()
        {
            int[] arr = new int[] { 1, 3, 2, 4, 5 };
            burbu.ordenar(arr);
            CollectionAssert.AreEqual(vesp, arr);
        }

        [TestMethod]
        public void ultimo()
        {
            int[] arr = new int[] { 5, 1, 2, 3, 4 };
            burbu.ordenar(arr);
            CollectionAssert.AreEqual(vesp, arr);
        }

        [TestMethod]
        public void primero()
        {
            int[] arr = new int[] { 2, 3, 4, 5, 1 };
            burbu.ordenar(arr);
            CollectionAssert.AreEqual(vesp, arr);
        }

        [TestMethod]
        public void invertido()
        {
            int[] arr = new int[] { 5, 4, 3, 2, 1 };
            burbu.ordenar(arr);
            CollectionAssert.AreEqual(vesp, arr);
        }
    }
}
