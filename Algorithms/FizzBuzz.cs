namespace Algorithms;

using System.Text;

public static class FizzBuzz
{
    /// <summary>
    /// An implementation of the fizz buzz algorithm
    /// </summary>
    /// <param name="names">The pairings of names to divisors</param>
    /// <param name="count">How many lines of output to generate</param>
    /// <returns>An enumerable of strings representing the output of the algorithm</returns>
    public static IEnumerable<string> Generate(
        List<(int Divisor, string Name)> names,
        int count
    )
    {
        var sb = new StringBuilder();
        for (var i = 1; i <= count; i++)
        {
            sb.Clear();
            foreach (var (divisor, name) in names)
            {
                if (i % divisor == 0)
                {
                    sb.Append(name);
                }
            }

            if (sb.Length == 0)
            {
                sb.Append(i);
            }

            yield return sb.ToString();
        }
    }
}