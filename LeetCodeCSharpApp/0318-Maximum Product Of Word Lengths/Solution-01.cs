namespace LeetCodeCSharpApp.MaximumProductOfWordLengths01;

public class Solution
{
    private uint WordToUInt(string word)
    {
        return word.ToCharArray().Aggregate(0u, (current, c) => current | (uint)(1 << (c - 97)));
    }

    public int MaxProduct(string[] words)
    {
        var ints = new uint[words.Length];

        for (var i = 0; i < words.Length; i++)
            ints[i] = WordToUInt(words[i]);

        var max = 0;

        for (var i = 0; i < words.Length - 1; i++)
            for (var j = i + 1; j < words.Length; j++)
                if ((ints[i] & ints[j]) == 0 && words[i].Length * words[j].Length > max)
                    max = words[i].Length * words[j].Length;

        return max;
    }
}
