using NUnit.Framework;
using MiAplicacion;
using System.Security.Cryptography.X509Certificates;

namespace MiAplicacion.Tests
{
    [TestFixture]
    public class CalculadoraTests
    {
        [SetUp]
        public void Setup()
        {
            
        }
        public class Calculadora
        {
            public Calculadora() { }

            public int Suma(int num1, int num2)
            {
                return num1 + num2;
            }
        }

        [Test]
        public void Suma_DosNumeros_DeberiaRetornarLaSuma()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            var resultado = calculadora.Suma(5, 5);

            // Assert
            Assert.AreEqual(10, resultado);
        }
    }
}