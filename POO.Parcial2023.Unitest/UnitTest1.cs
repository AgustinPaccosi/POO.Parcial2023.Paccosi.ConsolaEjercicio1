using Microsoft.VisualStudio.TestTools.UnitTesting;
using POO.Parcial2023.Entidades;
using System;

namespace POO.Parcial2023.Unitest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestInformarAltura()
        {
            PiramideCuadrada piram = new PiramideCuadrada(5, 10);
            Assert.AreEqual(5, piram.GetAltura());
        }
        [TestMethod]

        public void TestInformarLadoBase()
        {
            PiramideCuadrada piram = new PiramideCuadrada(5, 10);
            Assert.AreEqual(10, piram.GetLadoBase());
        }
        [TestMethod]

        public void TestInformarArista()
        {
            PiramideCuadrada piram = new PiramideCuadrada(5, 10);
            var arista = Math.Sqrt((Math.Pow(5, 2)) + (Math.Pow(10, 2) / 2));
            Assert.AreEqual(arista, piram.GetArista());
        }

        [TestMethod]

        public void TestInformarArea()
        {
            PiramideCuadrada piram = new PiramideCuadrada(5, 10);
            var area = 10 * (10 + (Math.Sqrt(4 * (Math.Pow(5, 2)) + (Math.Pow(10, 2)))));
            Assert.AreEqual(area, piram.Area());
        }

        [TestMethod]

        public void TestInformarVolumen()
        {
            PiramideCuadrada piram = new PiramideCuadrada(5, 10);
            var vol = (Math.Pow(10,2) * 5)/3;
            Assert.AreEqual(vol, piram.Volumen());
        }
        [TestMethod]

        public void TestInformarDatos()
        {
            PiramideCuadrada piram = new PiramideCuadrada(5, 10);
            var msj = "Devolucion imposible de realizar.";
            Assert.AreNotEqual(msj, piram.GetDatos());
        }

    }
}
