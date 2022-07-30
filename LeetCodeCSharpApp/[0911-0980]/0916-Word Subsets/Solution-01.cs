namespace LeetCodeCSharpApp.WordSubsets01;

public class Solution
{
    private readonly int[] _count = new int[26];

    public IList<string> WordSubsets(string[] words1, string[] words2)
    {
        foreach (var word in words2)
        {
            var tmp = Counter(word);

            for (var i = 0; i < 26; ++i)
                _count[i] = Math.Max(_count[i], tmp[i]);
        }

        return words1.Where(IsUniversal).ToList();
    }

    private bool IsUniversal(string word)
    {
        var tmp = Counter(word);
        int i;

        for (i = 0; i < 26; ++i)
            if (tmp[i] < _count[i])
                break;

        return i == 26;
    }

    private static int[] Counter(string word)
    {
        var count = new int[26];

        foreach (var c in word.ToCharArray())
            count[c - 'a']++;

        return count;
    }
}
