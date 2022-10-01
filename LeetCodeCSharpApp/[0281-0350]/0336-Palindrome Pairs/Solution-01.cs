namespace LeetCodeCSharpApp.PalindromePairs01;

public class Solution
{
    public IList<IList<int>> PalindromePairs(string[] words)
    {
        List<IList<int>> res = new();
        var dict = Enumerable.Range(0, words.Length).ToDictionary(x => words[x], x => x);

        foreach (var (word, i) in dict)
        {
            var r = string.Concat(word.Reverse());

            if (word.Length == 1 && dict.TryGetValue(string.Empty, out var j))
            {
                res.Add(new List<int> { i, j });
                res.Add(new List<int> { j, i });

                continue;
            }

            if (dict.TryGetValue(r, out j) && j != i)
                res.Add(new List<int> { i, j });

            for (var k = 0; k < word.Length; k++)
            {
                if (IsPalindrome(r[..^k]) && dict.TryGetValue(r[^k..], out j))
                    res.Add(new List<int> { i, j });

                if (IsPalindrome(r[k..]) && dict.TryGetValue(r[..k], out j))
                    res.Add(new List<int> { j, i });
            }
        }

        return res;
    }

    private static bool IsPalindrome(string s)
    {
        var i = 0;

        while (i < s.Length / 2)
            if (s[i++] != s[^i])
                return false;

        return true;
    }
}
