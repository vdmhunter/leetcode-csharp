namespace LeetCodeCSharpApp.NumberOfWaysToFormATargetStringGivenADictionary01;

public class Solution
{
    private const long Mod = 1_000_000_007L;

    public int NumWays(string[] words, string target)
    {
        var n = target.Length;
        var result = new long[n + 1];
        result[0] = 1;

        for (var i = 0; i < words[0].Length; i++)
        {
            var count = new int[26];

            foreach (var w in words)
                count[w[i] - 'a']++;

            for (var j = n - 1; j >= 0; j--)
            {
                result[j + 1] += result[j] * count[target[j] - 'a'] % Mod;
                result[j + 1] %= Mod;
            }
        }

        return (int)(result[n] % Mod);
    }
}
