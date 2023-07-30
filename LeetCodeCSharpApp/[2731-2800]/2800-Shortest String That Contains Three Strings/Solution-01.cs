namespace LeetCodeCSharpApp.ShortestStringThatContainsThreeStrings01;

public class Solution
{
    public string MinimumString(string a, string b, string c)
    {
        return new[]
            {
                Combine(Combine(a, b), c),
                Combine(Combine(a, c), b),
                Combine(Combine(b, a), c),
                Combine(Combine(b, c), a),
                Combine(Combine(c, a), b),
                Combine(Combine(c, b), a)
            }.OrderBy(item => item.Length)
            .ThenBy(item => item)
            .First();
    }

    private static string Combine(string a, string b)
    {
        if (a.Contains(b))
            return a;

        if (b.Contains(a))
            return b;

        for (var prefix = Math.Min(a.Length, b.Length); prefix >= 0; --prefix)
            if (b[..prefix] == a[^prefix..])
                return a + b[prefix..];

        return a + b;
    }
}
