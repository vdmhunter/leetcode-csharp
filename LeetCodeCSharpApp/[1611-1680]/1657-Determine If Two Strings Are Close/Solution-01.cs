namespace LeetCodeCSharpApp.DetermineIfTwoStringsAreClose01;

public class Solution
{
    public bool CloseStrings(string word1, string word2)
    {
        var hs = new HashSet<char>(word2);
        int[] freq1 = new int[26], freq2 = new int[26];

        foreach (var c in word1)
        {
            freq1[c - 'a']++;
            if (hs.Add(c)) return false;
        }

        foreach (var c in word2)
            freq2[c - 'a']++;

        Array.Sort(freq1);
        Array.Sort(freq2);

        return freq1.SequenceEqual(freq2);
    }
}
