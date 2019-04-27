using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TreinaWeb.Calculadora.xUnit
{
    public class SubtrairTests
    {
        Util.Calculadora calc;

        public SubtrairTests() {
            calc = new Util.Calculadora();
        }

        [Fact]
        public void TestSubtracaoNumerosPositivos() {
            Assert.Equal(-1, calc.Subtrair(3, 4));
        }

        [Fact]
        public void TestSubtracaoAbaixoLimitePrimeiroArgumento() {
            Assert.Throws<ArgumentOutOfRangeException>(() => calc.Subtrair(-1, 1));
        }

        [Fact]
        public void TestSubtracaoAbaixoLimiteSegundoArgumento() {
            Assert.Throws<ArgumentOutOfRangeException>(() => calc.Subtrair(1, -1));
        }

        [Fact]
        public void TestSubtracaoAbaixoLimiteAmbosArgumentos() {
            Assert.Throws<ArgumentOutOfRangeException>(() => calc.Subtrair(-1, -1));
        }
    }
}
