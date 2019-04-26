using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TreinaWeb.Calculadora.xUnit
{
    public class TestCalculadora : IDisposable
    {
        Util.Calculadora calc;

        public TestCalculadora() {
            calc = new Util.Calculadora(2);
        }

        public void Dispose() {
            calc = null;
        }

        [Fact]
        public void TestSomar() {
            Assert.Equal(4, calc.Somar(2, 2));
        }

        [Fact]
        public void TestComarComLimite() {
            Assert.Equal(6, calc.Somar(3, 3));
        }

        [Fact]
        public void TestSomarForaDoLimite() {
            Assert.Throws<ArgumentOutOfRangeException>(() => calc.Somar(1,1));
        }

        [Fact(Skip = "Método ainda não implementado")]
        public void TestMultiplicar() {

        }
    }
}
