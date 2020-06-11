using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab6_1;

namespace Testy_Silnia
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Silnia0()
        {
            Silnia Sil2 = new Silnia();
            Sil2.n = 0;
            Assert.AreEqual(Sil2.oblicz(), 1);
        }

        [TestMethod]
        public void Silnia1()
        {
            Silnia Sil2 = new Silnia();
            Sil2.n = 1;
            Assert.AreEqual(Sil2.oblicz(), 1);
        }

        [TestMethod]
        public void Silnia5()
        {
            Silnia Sil2 = new Silnia();
            Sil2.n = 5;
            Assert.AreEqual(Sil2.oblicz(), 120);
        }

    }

    }