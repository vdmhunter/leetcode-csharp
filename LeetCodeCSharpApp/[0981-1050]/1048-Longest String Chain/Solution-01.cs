namespace LeetCodeCSharpApp.LongestStringChain01;

public class Solution
{
    public int LongestStrChain(string[] words)
    {
        Array.Sort(words, (x, y) => x.Length.CompareTo(y.Length));

        var wordsLength = words.Distinct().ToDictionary(word => word, _ => 1);

        var max = 0;
        foreach (var word in words)
        {
            for (var i = 0; i < word.Length; i++)
            {
                var prevWord = word[..i] + word[(i + 1)..];
                if (wordsLength.ContainsKey(prevWord))
                    wordsLength[word] = Math.Max(wordsLength[word], wordsLength[prevWord] + 1);
            }

            max = Math.Max(max, wordsLength[word]);
        }

        return max;
    }
}
