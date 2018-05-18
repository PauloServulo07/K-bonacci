using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using k_bonacci;

namespace k_bonacci.teste
{
    [TestClass]
    public class KbonacciTeste
    {
        [TestMethod]
        public void k_bonacci_teste_k3_n4()
        {
            Kbonacci kbonacci = new Kbonacci();
            int k = 3, n = 4;
            long resultado_esperado = 5;
            long resultado = kbonacci.k_bonacci(k, n);
            Assert.AreEqual(resultado, resultado_esperado);
        }

        [TestMethod]
        public void k_bonacci_teste_k2_n4()
        {
            Kbonacci kbonacci = new Kbonacci();
            int k = 2, n = 4;
            long resultado_esperado = 5;
            long resultado = kbonacci.k_bonacci(k, n);
            Assert.AreEqual(resultado, resultado_esperado);
        }

        [TestMethod]
        public void k_bonacci_teste_k2_n0()
        {
            Kbonacci kbonacci = new Kbonacci();
            int k = 2, n = 0;
            long resultado_esperado = 1;
            long resultado = kbonacci.k_bonacci(k, n);
            Assert.AreEqual(resultado, resultado_esperado);
        }

        [TestMethod]
        public void k_bonacci_teste_k5_n0()
        {
            Kbonacci kbonacci = new Kbonacci();
            int k = 5, n = 0;
            long resultado_esperado = 1;
            long resultado = kbonacci.k_bonacci(k, n);
            Assert.AreEqual(resultado, resultado_esperado);
        }

        [TestMethod]
        public void k_bonacci_teste_k5_n5()
        {
            Kbonacci kbonacci = new Kbonacci();
            int k = 5, n = 5;
            long resultado_esperado = 5;
            long resultado = kbonacci.k_bonacci(k, n);
            Assert.AreEqual(resultado, resultado_esperado);
        }

        [TestMethod]
        public void k_bonacci_teste_k5_n10()
        {
            Kbonacci kbonacci = new Kbonacci();
            int k=5, n=10;
            long resultado_esperado = 129;
            long resultado = kbonacci.k_bonacci(k, n);
            Assert.AreEqual(resultado, resultado_esperado);
        }

        [TestMethod]
        public void k_bonacci_teste_k9_n20()
        {
            Kbonacci kbonacci = new Kbonacci();
            int k = 9, n = 20;
            long resultado_esperado = 16353;
            long resultado = kbonacci.k_bonacci(k, n);
            Assert.AreEqual(resultado, resultado_esperado);
        }

        [TestMethod]
        public void k_bonacci_teste_k5_n30()
        {
            Kbonacci kbonacci = new Kbonacci();
            int k = 5, n = 30;
            long resultado_esperado = 95653929;
            long resultado = kbonacci.k_bonacci(k, n);
            Assert.AreEqual(resultado, resultado_esperado);
        }

        [TestMethod]
        public void k_bonacci_teste_k30_n50()
        {
            Kbonacci kbonacci = new Kbonacci();
            int k = 30, n = 50;
            long resultado_esperado = 30408705;
            long resultado = kbonacci.k_bonacci(k, n);
            Assert.AreEqual(resultado, resultado_esperado);
        }
    }
}
