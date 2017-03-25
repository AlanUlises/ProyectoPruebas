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
        public void ordernado()
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
    }
}
