using System;
using Xunit;
using CalculadoraContaminacionRios.Services;

namespace CalculadoraContaminacionRios.Tests.Services
{
    public class IntegracionServiceTests
    {
        private readonly IntegracionService _integracionService;

        public IntegracionServiceTests()
        {
            _integracionService = new IntegracionService();
        }

        [Fact]
        public void CalcularTrapecio_ValidInput_ReturnsCorrectResult()
        {
            // Arrange
            Func<double, double> funcion = x => x; // Ejemplo de función f(x) = x
            double a = 0;
            double b = 10;
            int n = 100;

            // Act
            double resultado = _integracionService.CalcularTrapecio(funcion, a, b, n);

            // Assert
            Assert.Equal(50, resultado, 2); // La integral de f(x) = x desde 0 a 10 es 50
        }

        [Fact]
        public void CalcularSimpson_ValidInput_ReturnsCorrectResult()
        {
            // Arrange
            Func<double, double> funcion = x => x; // Ejemplo de función f(x) = x
            double a = 0;
            double b = 10;
            int n = 100; // n debe ser par para el método de Simpson

            // Act
            double resultado = _integracionService.CalcularSimpson(funcion, a, b, n);

            // Assert
            Assert.Equal(50, resultado, 2); // La integral de f(x) = x desde 0 a 10 es 50
        }

        [Fact]
        public void CalcularTrapecio_InvalidInput_ThrowsArgumentException()
        {
            // Arrange
            Func<double, double> funcion = x => x; // Ejemplo de función f(x) = x
            double a = 10;
            double b = 0;
            int n = 100;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => _integracionService.CalcularTrapecio(funcion, a, b, n));
        }

        [Fact]
        public void CalcularSimpson_InvalidInput_ThrowsArgumentException()
        {
            // Arrange
            Func<double, double> funcion = x => x; // Ejemplo de función f(x) = x
            double a = 10;
            double b = 0;
            int n = 99; // n debe ser par para el método de Simpson

            // Act & Assert
            Assert.Throws<ArgumentException>(() => _integracionService.CalcularSimpson(funcion, a, b, n));
        }
    }
}