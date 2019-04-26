using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwCalc = TreinaWeb.Calculadora.Util;

namespace TreinaWeb.Calculadora.MSTests
{
    [TestClass]
    public class CalculadoraTests
    {
        private TwCalc.Calculadora calc;

        [TestInitialize]
        public void SetUp() {
            calc = new TwCalc.Calculadora();
        }

        [TestCleanup]
        public void CleanUp() {
            calc = null;
        }

        [TestMethod]
        public void TestSomar() {
            Assert.AreEqual(4, calc.Somar(2, 2));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SomarComException() {
            TwCalc.Calculadora calc = new TwCalc.Calculadora(2);
            calc.Somar(1, 1);
            /* Outro jeito de esperar por uma exceção no código de teste seria
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => calc.Somar(1, 1));

            Neste caso, o atributo ExpectedException não seria necessário.
            */
        }

        [TestMethod]
        public void TestSubtrair() {
            Assert.AreEqual(0, calc.Subtrair(2, 2));
        }

        [TestMethod]
        [Ignore]
        public void TestMultiplicar() {

        }
    }
}
