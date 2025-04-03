using System;

namespace CalculadoraContaminacionRios.Services
{
    /// <summary>
    /// Provides methods for calculating integrals using the Trapezoidal and Simpson's methods.
    /// </summary>
    public class TrapecioSimpsonService
    {
        /// <summary>
        /// Calculates the integral using the Trapezoidal method.
        /// </summary>
        /// <param name="f">Function representing the product C(x)·v(x).</param>
        /// <param name="a">Lower limit.</param>
        /// <param name="b">Upper limit.</param>
        /// <param name="n">Number of partitions.</param>
        /// <returns>Approximate value of the integral.</returns>
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
        /// Calculates the integral using Simpson's method.
        /// </summary>
        /// <param name="f">Function representing the product C(x)·v(x).</param>
        /// <param name="a">Lower limit.</param>
        /// <param name="b">Upper limit.</param>
        /// <param name="n">Number of partitions (must be even).</param>
        /// <returns>Approximate value of the integral.</returns>
        public double CalcularSimpson(Func<double, double> f, double a, double b, int n)
        {
            if (n % 2 != 0)
            {
                throw new ArgumentException("n must be even.");
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