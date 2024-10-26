using System;
using System.Linq;

namespace Algorithms.Numeric.Factorization;

/// <summary>
///     Factors number using trial division algorithm.
/// </summary>
public class TrialDivisionFactorizer : IFactorizer
{
    /// <summary>
    ///     Finds the smallest non trivial factor (i.e.: 1 &lt; factor &lt;= sqrt(<paramref name="n" />)) of a given number or returns false if it's prime.
    /// </summary>
    /// <param name="n">Integer to factor.</param>
    /// <param name="factor">Found factor.</param>
    /// <returns><see langword="true" /> if factor is found, <see langword="false" /> if <paramref name="n" /> is prime.</returns>
    public bool TryFactor(int n, out int factor)
    {
        n = Math.Abs(n);
        factor = Enumerable.Range(2, (int)Math.Sqrt(n) - 1).FirstOrDefault(i => n % i == 0);
        return factor != 0;
    }
}
