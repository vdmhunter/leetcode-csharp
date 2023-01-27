namespace LeetCodeCSharpApp.TopKFrequentWords01;

/// <summary>
/// LINQ
/// </summary>
public class Solution
{
    public IList<string> TopKFrequent(string[] words, int k)
    {
        return words.GroupBy(w => w).OrderBy(g => (-g.Count(), g.Key)).Select(g => g.Key).Take(k).ToList();
    }
}
