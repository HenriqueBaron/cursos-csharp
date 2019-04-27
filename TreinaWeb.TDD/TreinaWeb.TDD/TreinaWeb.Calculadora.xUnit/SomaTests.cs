using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TreinaWeb.Calculadora.xUnit
{
    public class SomaTests
    {
        Util.Calculadora calc;

        public SomaTests() {
            calc = new Util.Calculadora();
        }

        [Fact]
        public void TestSomaNumerosPositivos() {
            Assert.Equal(4, calc.Somar(2, 2));
        }

        [Fact]
        public void TestSomaAbaixoLimitePrimeiroArgumento() {
            Assert.Throws<ArgumentOutOfRangeException>(() => calc.Somar(-1, 0));
        }

        [Fact]
        public void TestSomaAbaixoLimiteSegundoArgumento() {
            Assert.Throws<ArgumentOutOfRangeException>(() => calc.Somar(0, -1));
        }

        [Fact]
        public void TestSomaAbaixoLimiteAmbosArgumentos() {
            Assert.Throws<ArgumentOutOfRangeException>(() => calc.Somar(-1, -1));
        }
    }
}