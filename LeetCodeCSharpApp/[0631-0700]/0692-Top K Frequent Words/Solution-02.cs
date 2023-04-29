namespace LeetCodeCSharpApp.TopKFrequentWords02;

/// <summary>
/// PriorityQueue (via SortedSet and IComparer)
/// </summary>
public class Solution
{
    public IList<string> TopKFrequent(string[] words, int k)
    {
        var frequencyMap = new Dictionary<string, int>();

        foreach (var word in words)
        {
            frequencyMap.TryGetValue(word, out var count);
            frequencyMap[word] = count + 1;
        }

        var sortedWords = new SortedSet<string>(frequencyMap.Keys, new WordAndFrequencyComparer(frequencyMap));

        var result = new List<string>();

        foreach (var word in sortedWords)
        {
            if (result.Count == k)
                break;

            result.Add(word);
        }

        return result;
    }

    private class WordAndFrequencyComparer : IComparer<string>
    {
        private readonly Dictionary<string, int> _frequencyMap;

        public WordAndFrequencyComparer(Dictionary<string, int> frequencyMap)
        {
            _frequencyMap = frequencyMap;
        }

        public int Compare(string? left, string? right)
        {
            var frequencyComparison = _frequencyMap[right!].CompareTo(_frequencyMap[left!]);

            return frequencyComparison == 0
                ? string.Compare(left, right, StringComparison.InvariantCulture)
                : frequencyComparison;
        }
    }
}
