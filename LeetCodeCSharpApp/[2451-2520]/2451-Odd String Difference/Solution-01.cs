namespace LeetCodeCSharpApp.OddStringDifference01;

public class Solution
{
    public string OddString(string[] words)
    {
        var counts = new Dictionary<string, (int Count, string Word)>(2);

        foreach (var word in words)
        {
            var arr = GetDifferenceArrayAsString(word);

            if (counts.ContainsKey(arr))
                counts[arr] = (counts[arr].Count + 1, counts[arr].Word);
            else
                counts.Add(arr, (1, word));
        }

        return counts.MinBy(d => d.Value.Count).Value.Word;
    }

    private string GetDifferenceArrayAsString(string word)
    {
        return string.Join(",", word.Skip(1).Zip(word, (curr, prev) => curr - prev));
    }
}
