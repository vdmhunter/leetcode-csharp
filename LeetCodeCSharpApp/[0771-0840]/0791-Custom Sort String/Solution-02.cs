using System.Text;

namespace LeetCodeCSharpApp.CustomSortString02;

/// <summary>
///   Frequency Table and Counting
///
///   Time Complexity: O(N)
///   Space Complexity: O(N)
/// </summary>
public class Solution
{
    public string CustomSortString(string order, string s)
    {
        var freq = new Dictionary<char, int>();
        var result = new StringBuilder();

        foreach (char ch in s)
            freq[ch] = freq.GetValueOrDefault(ch) + 1;

        foreach (char ch in order)
        {
            if (!freq.ContainsKey(ch))
                continue;

            int count = freq[ch];
            result.Append(ch, count);
            freq.Remove(ch);
        }

        foreach (var pair in freq)
            result.Append(pair.Key, pair.Value);

        return result.ToString();
    }
}
