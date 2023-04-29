namespace LeetCodeCSharpApp.FindAndReplacePattern02;

public class Solution
{
    public IList<string> FindAndReplacePattern(string[] words, string pattern)
    {
        var p = F(pattern);

        return words.Where(w => F(w).SequenceEqual(p)).ToList();
    }

    private static int[] F(string w)
    {
        var m = new Dictionary<char, int>();
        var n = w.Length;
        var result = new int[n];

        for (var i = 0; i < n; i++)
        {
            m.TryAdd(w[i], m.Count);
            result[i] = m[w[i]];
        }

        return result;
    }
}
