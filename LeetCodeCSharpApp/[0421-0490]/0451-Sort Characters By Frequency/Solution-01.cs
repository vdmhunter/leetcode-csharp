namespace LeetCodeCSharpApp.SortCharactersByFrequency01;

public class Solution
{
    public string FrequencySort(string s)
    {
        return string.Concat(s.GroupBy(c => c).OrderByDescending(g => g.Count()).SelectMany(g => g));
    }
}
