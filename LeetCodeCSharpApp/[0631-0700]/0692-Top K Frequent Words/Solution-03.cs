namespace LeetCodeCSharpApp.TopKFrequentWords03;

/// <summary>
/// Bucket sort with sorted sets instead of lists of string
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

        var buckets = new SortedSet<string>[frequencyMap.Count + 1];
        
        foreach (var frequency in frequencyMap)
            if (buckets[frequency.Value] == null)
                buckets[frequency.Value] = new SortedSet<string> { frequency.Key };
            else
                buckets[frequency.Value].Add(frequency.Key);

        var result = new List<string>();
        
        for (var frequency = frequencyMap.Count; frequency > 0 && result.Count < k; frequency--)
            if (buckets[frequency] != null)
                foreach (var word in buckets[frequency])
                {
                    if (result.Count == k)
                        break;
                    result.Add(word);
                }

        return result;
    }
}
