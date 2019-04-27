using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TreinaWeb.Calculadora.xUnit
{
    public class DividirTests
    {
        Util.Calculadora calc;

        public DividirTests() {
            calc = new Util.Calculadora();
        }

        [Fact]  
        public void TestDivisao() {
            Assert.Equal(3, calc.Dividir(9, 3));
        }

        [Fact]
        public void TestDivisaoAbaixoLimitePrimeiroArgumento() {
            Assert.Throws<ArgumentOutOfRangeException>(() => calc.Dividir(-1, 3));
        }

        [Fact]  
        public void TestDivisaoAbaixoLimiteSegundoArgumento() {
            Assert.Throws<ArgumentOutOfRangeException>(() => calc.Dividir(9, -3));
        }

        [Fact]
        public void TestDivisaoAbaixoLimiteAmbosArgumentos() {
            Assert.Throws<ArgumentOutOfRangeException>(() => calc.Dividir(-3, -3));
        }

        [Fact]
        public void TestDivisaoDivisorIgualAZero() {
            Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
        }
    }
}
