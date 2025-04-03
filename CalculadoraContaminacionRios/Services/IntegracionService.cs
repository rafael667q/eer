using System;

namespace CalculadoraContaminacionRios.Services
{
    /// <summary>
    /// Clase que proporciona métodos para la integración numérica.
    /// </summary>
    public class IntegracionService
    {
        /// <summary>
        /// Calcula la integral definida usando el método del trapecio.
        /// </summary>
        /// <param name="f">Función que representa el producto C(x)·v(x).</param>
        /// <param name="a">Límite inferior.</param>
        /// <param name="b">Límite superior.</param>
        /// <param name="n">Número de particiones.</param>
        /// <returns>Valor aproximado de la integral.</returns>
        public double CalcularTrapecio(Func<double, double> f, double a, double b, int n)
        {
            double h = (b - a) / n;
            double suma = 0.5 * (f(a) + f(b));
            for (int i = 1; i < n; i++)
            {
                suma += f(a + i * h);
            }
            return suma * h;
        }

        /// <summary>
        /// Calcula la integral definida usando el método de Simpson.
        /// </summary>
        /// <param name="f">Función que representa el producto C(x)·v(x).</param>
        /// <param name="a">Límite inferior.</param>
        /// <param name="b">Límite superior.</param>
        /// <param name="n">Número de particiones (debe ser par).</param>
        /// <returns>Valor aproximado de la integral.</returns>
        public double CalcularSimpson(Func<double, double> f, double a, double b, int n)
        {
            if (n % 2 != 0)
            {
                throw new ArgumentException("El número de particiones debe ser par.");
            }

            double h = (b - a) / n;
            double suma = f(a) + f(b);
            for (int i = 1; i < n; i++)
            {
                suma += (i % 2 == 0) ? 2 * f(a + i * h) : 4 * f(a + i * h);
            }
            return suma * h / 3;
        }
    }
}