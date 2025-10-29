namespace Algorithms;

using System.Text;

public static class FizzBuzz
{
    public static IEnumerable<string> Generate(List<(int Divisor, string Name)> names, int upperBound)
    {
        var sb = new StringBuilder();
        for (var i = 1; i <= upperBound; i++)
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