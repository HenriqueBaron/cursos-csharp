using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TreinaWeb.Calculadora.xUnit
{
    public class MultiplicacaoTests : IDisposable
    {
        Util.Calculadora calc;

        public MultiplicacaoTests() {
            calc = new Util.Calculadora(2);
        }

        public void Dispose() {
            calc = null;
        }

        [Fact]
        public void TestMultiplicacao() {
            Assert.Equal(9, calc.Multiplicar(3, 3));
        }

        [Fact]
        public void TestMultiplicacaoPrimeiroArgumentoAbaixoLimite() {
            Assert.Throws<ArgumentOutOfRangeException>(() => calc.Multiplicar(1, 3));
        }

        [Fact]  
        public void TestMultiplicacaoSegundoArgumentoAbaixoLimite() {
            Assert.Throws<ArgumentOutOfRangeException>(() => calc.Multiplicar(3, 1));
        }

        [Fact]  
        public void TestMultiplicacaoAmbosArgumentosAbaixoLimite() {
            Assert.Throws<ArgumentOutOfRangeException>(() => calc.Multiplicar(1, 1));
        }
    }
}
