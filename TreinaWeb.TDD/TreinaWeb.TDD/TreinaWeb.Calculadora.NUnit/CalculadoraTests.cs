using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace TreinaWeb.Calculadora.NUnit
{
    [TestFixture]
    public class CalculadoraTests
    {
        private Util.Calculadora calc;

        [OneTimeSetUp]
        public void SetUp() {
            calc = new Util.Calculadora();
        }

        [OneTimeTearDown]
        public void TearDown() {
            calc = null;
        }

        [Test]
        public void TestSomar() {
            Assert.AreEqual(4, calc.Somar(2, 2));
        }

        [Test]
        public void SomarComException() {
            /* No NUnit 3, o atributo ExpectedException foi removido. dessa maneira, o
             * teste de exceção deve ser feito com o Assert */
            Util.Calculadora calculadora = new Util.Calculadora(2);
            Assert.Throws<ArgumentOutOfRangeException>(() => calculadora.Somar(1, 1));
        }

        [Test]
        public void TestSubtrair() {
            Assert.AreEqual(0, calc.Subtrair(2, 2));
        }

        [Test]
        [Ignore("Método ainda não implementado")]
        public void MultiplicarTest() {

        }

        [Test]
        [Ignore("Método ainda não implementado")]
        public void DividirTest() {

        }
    }
}
