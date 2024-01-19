namespace MiProyecto.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        // Arrange
            var calculadora = new Calculadora();

            // Act
            var resultado = calculadora.Suma(5, 5);

            // Assert
            Assert.AreEqual(10, resultado);
    }
}