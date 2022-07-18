namespace LeetCodeCSharpApp.TopKFrequentWords01;

/// <summary>
/// LINQ
/// </summary>
public class Solution
{
    public IList<string> TopKFrequent(string[] words, int k)
    {
        return words
            .GroupBy(word => word)
            .OrderByDescending(freq => freq.Count())
            .ThenBy(freq => freq.Key)
            .Take(k)
            .Select(freq => freq.Key)
            .ToList();
    }
}
