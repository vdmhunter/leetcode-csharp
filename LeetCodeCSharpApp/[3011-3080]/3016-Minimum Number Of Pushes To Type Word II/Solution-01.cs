namespace LeetCodeCSharpApp.MinimumNumberOfPushesToTypeWordII01;

public class Solution
{
    public int MinimumPushes(string word)
    {
        var charCounts = new int[26];

        IEnumerable<int> indices = word
            .Select(ch => ch - 'a')
            .Where(index => index is >= 0 and < 26);

        foreach (int index in indices)
            charCounts[index]++;

        Array.Sort(charCounts, (a, b) => b.CompareTo(a));

        var pushes = 0;

        for (var i = 0; i < 26 && charCounts[i] > 0; i++)
            pushes += (i / 8 + 1) * charCounts[i];

        return pushes;
    }
}
